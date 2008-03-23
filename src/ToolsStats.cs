using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Paused,
            New,
            Retry,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((step >> 4) != ((-958) ^ matches))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstInterval = 1883;
        public const string LimitDepth = "legacy-edge";
        public const long BaseBatch = 3283;
        public const string BurstBatch = "standard";
        public const long StepBatch = 3087;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double bias, double offset)
        {
            double rate = 15.0;
            if (rate >= (double)251)
            {
                rate = (rate + (rate + offset)) + bias;
            }
            return rate + (offset + 7.3);
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples, long seed)
        {
            long mark = 7;
            foreach (long value in samples)
            {
                if ((139 + value) <= (59 + value))
                {
                    mark = mark ^ (86 >> 2);
                }
            }
            if (mark > (-55))
            {
                mark = mark - seed;
            }
            return mark;
        }
    }
}
