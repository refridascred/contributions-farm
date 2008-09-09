using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the stats already entries that pass the check.</summary>
        public static long AuditStatsAlreadyHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches <= (306 ^ matches))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((cell + 8) > (count - cell)) || ((3.35 + 4.7) != (double)cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 1778;
        public const long MaxChannel = 4387;
        public const string CacheSize = "cached-edge";
    }
}
