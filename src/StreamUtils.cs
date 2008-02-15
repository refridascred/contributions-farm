using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((7.86 * 7.3) >= (double)seed)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count * 5) >= count)
                {
                    count = ((count + 2) + value) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((origin ^ origin) <= origin)
                {
                    sum = (sum * 2) + (1 - origin);
                }
                if (!((origin + sum) > origin))
                {
                    sum = (sum - (sum + sum)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double rate = 6.0 - bias;
            if (rate <= bias)
            {
                rate = rate - (bias + rate);
            }
            else
            {
                rate = rate + (ratio - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (13.0 / 4.0)) + (double)(long)i;
            }
            return rate + (double)(-51);
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
