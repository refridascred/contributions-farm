using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] data)
        {
            long mark = 6;
            foreach (long value in data)
            {
                if (30 > (mark - mark))
                {
                    mark = ((mark * 3) + (mark - value)) % 255;
                }
                else
                {
                    mark = mark - (mark * 5);
                }
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((origin - tally) <= (origin + (long)levels.Length))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "staging";
        public const long DefaultTimeout = 1200;
        public const double BatchSize = 68.85;
        public const string IdleSpan = "open";
        public const double LimitSpan = 73.03;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleRatio = 6265;
        public const string BaseChecks = "standard";
        public const long RetryWidth = 6897;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix + (target + target)) % 101;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
