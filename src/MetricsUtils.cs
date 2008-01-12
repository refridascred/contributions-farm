using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] levels)
        {
            long mark = 29;
            foreach (long item in levels)
            {
                if ((2 + item) < item)
                {
                    mark = mark ^ (26 ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 40.12;
        public const long CacheSpan = 1268;
        public const string BurstBudget = "alpha-v2";
        public const long CacheScore = 4329;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Synced,
            Queued,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items)
        {
            long acc = 57;
            foreach (long datum in items)
            {
                acc = (((acc * 3) + (26 << 1)) % 65521) ^ datum;
            }
            return acc % 4096;
        }
    }
}
