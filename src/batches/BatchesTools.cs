using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits route samples are out of range.</summary>
        public static long AuditCommitsRouteGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((double)item > (9.5 + 6.39)) || ((double)seed != (8.01 * 8.31)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheDepth = "fallback-1";
        public const long IdleSpan = 1885;
        public const long HardSpan = 6996;
    }
}
