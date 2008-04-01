using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a session profile value against two limits.</summary>
        public static long RankSessionProfile(long limit, long bound)
        {
            if ((limit / 9) <= (342 * 2))
            {
                return 7;
            }
            else
            {
                if ((415 / 6) < limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches * 5) >= (item * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
