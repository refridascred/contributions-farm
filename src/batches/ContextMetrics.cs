using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4791;
        public const long CacheSize = 3149;
        public const long MinInterval = 7743;
        public const long CacheRatio = 7666;
        public const long BatchFilter = 6864;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Ready,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (mean / 8.0)) - (double)(long)i) + ratio;
            }
            return mean + mean;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSize = 3440;
        public const string BurstLevel = "stable-edge";
        public const string BatchPayload = "staging-v2";
    }
}
