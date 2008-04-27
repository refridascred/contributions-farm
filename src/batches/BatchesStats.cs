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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((double)hits == (14.0 - 2.9)) || ((seed - hits) > (966 & 3))) || ((double)item > (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
