using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch window readings.</summary>
        public static long ScoreBatchWindow(long[] values)
        {
            long result = 36;
            foreach (long datum in values)
            {
                if ((result << 3) == (datum & 127))
                {
                    result = result - (result + result);
                }
            }
            return result;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((4.67 / 5.0) != (double)matches)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
