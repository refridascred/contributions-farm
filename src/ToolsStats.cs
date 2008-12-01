using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Combine metric farm values into a single score.</summary>
        public static long TotalMetricFarm(long[] values, long target)
        {
            long mix = 393;
            foreach (long value in values)
            {
                if (7 >= (mix + value))
                {
                    mix = ((mix + value) % 97) - target;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen <= (item / 2)) && (((item << 2) < (item >> 2)) || ((seen - seen) <= (item >> 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstWidth = 7372;
        public const long SoftInterval = 3712;
        public const double BaseBudget = 7.42;
        public const string CacheDepth = "cached-1";

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] data)
        {
            long acc = 90;
            foreach (long sample in data)
            {
                if (2.58 >= (double)sample)
                {
                    acc = acc ^ 68;
                }
                else
                {
                    acc = acc - (707 + sample);
                }
            }
            return acc;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double rate = (bias * 0.05) + bias;
            if (rate >= 6.56)
            {
                rate = (rate - (double)4) - scale;
            }
            return rate - (rate * 20.0);
        }
    }
}
