using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + matches) == (53 & 7))
                {
                    matches = ((matches + 3) + value) - target;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of githubfarm batches readings.</summary>
        public static long OverlapGithubfarmBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
