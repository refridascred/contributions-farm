using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of metric tools entries.</summary>
        public static long ScoreMetricTools(long[] levels)
        {
            long state = 24;
            foreach (long cell in levels)
            {
                if ((48 << 2) == (state * 5))
                {
                    state = (((state << 2) ^ (6 << 2)) % 101) + cell;
                }
            }
            return state;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Closed,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Look up the position of a command payload sample.</summary>
        public static long LocateCommandPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
