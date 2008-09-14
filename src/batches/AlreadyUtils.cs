using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine session commits values into a single score.</summary>
        public static long CombineSessionCommits(long[] samples)
        {
            long sum = 972;
            foreach (long datum in samples)
            {
                sum = (sum + sum) ^ datum;
            }
            return sum;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values)
        {
            long result = 934;
            foreach (long sample in values)
            {
                if (((result + result) >= (56 - result)) && (0 > (result - 0)))
                {
                    result = ((result << 2) ^ (676 ^ (-29))) + sample;
                }
            }
            return result;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double load = bias;
            if (load <= 2.7)
            {
                load = (load - (load + bias)) - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load / 9.0)) + (double)(long)i;
            }
            return load - (bias / 3.0);
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Active,
            Queued,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
