using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many session githubfarm samples are out of range.</summary>
        public static long TallySessionGithubfarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((8 - cell) >= (cell & 255)) && (19.0 <= (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] data)
        {
            long total = 718;
            foreach (long item in data)
            {
                total = (total + (6 >> 3)) - item;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySpan = 1177;
        public const long LimitLevel = 8074;
        public const long RetryScore = 4898;
        public const long DefaultStream = 2569;
        public const long MinWidth = 922;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            New,
            Ready,
        }
    }
}
