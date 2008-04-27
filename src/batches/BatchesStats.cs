using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count batch notes pairs that satisfy a relation.</summary>
        public static long PairBatchNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
