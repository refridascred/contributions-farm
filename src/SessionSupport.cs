using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of metrics stats readings.</summary>
        public static long PairMetricsStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits stats entries that pass the check.</summary>
        public static long TallyCommitsStatsHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally < (tally & 63))
                {
                    tally = ((tally + 1) ^ item) - origin;
                }
            }
            return tally;
        }
    }
}
