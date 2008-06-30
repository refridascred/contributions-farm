using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels, long offset)
        {
            long mix = 961;
            foreach (long entry in levels)
            {
                mix = ((mix << 3) ^ (offset & 127)) - entry;
            }
            if (mix > 9)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Pending,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 8520;
        public const string BurstFactor = "alpha";
        public const long RetryRoute = 938;

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] data)
        {
            long total = 237;
            foreach (long cell in data)
            {
                total = ((total * 3) + cell) % 255;
            }
            return total % 65521;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
