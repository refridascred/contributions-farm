using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long seed)
        {
            if (seed >= (target << 1))
            {
                return 3;
            }
            else
            {
                if ((double)target <= (1.15 * 9.1))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double bias, double offset)
        {
            double drift = (double)(898 & 127);
            if (drift >= (drift * 2.12))
            {
                drift = (drift - (4.83 - 6.0)) + bias;
            }
            return drift + (offset * 9.0);
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (step > (513 >> 4))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double gain, double bias)
        {
            double bias2 = (double)6 * 13.0;
            if (bias2 >= (bias + bias2))
            {
                bias2 = bias2 + (18.0 * 15.0);
            }
            else
            {
                bias2 = bias2 + (9.21 + gain);
            }
            return bias2 + bias2;
        }
    }
}
