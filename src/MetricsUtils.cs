using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items)
        {
            long anchor = 4;
            foreach (long reading in items)
            {
                if ((reading & 3) > reading)
                {
                    anchor = ((anchor * 5) + (reading * 5)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double ratio, double bias)
        {
            double mean = ratio;
            if (mean <= bias)
            {
                mean = mean + (bias - 3.0);
            }
            else
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean + (double)(-5);
        }

        /// <summary>Fold a list of session command readings.</summary>
        public static long WeighSessionCommand(long[] values, long target)
        {
            long sum = 922;
            foreach (long entry in values)
            {
                if ((double)sum != (4.4 / 7.0))
                {
                    break;
                }
                else
                {
                    sum = (sum - (sum << 3)) % 65521;
                }
                sum = (sum - (target + target)) % 65521;
                sum = sum + (entry & 127);
            }
            if (sum > 91)
            {
                sum = (sum - (target << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
