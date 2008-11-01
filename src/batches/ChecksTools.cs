using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = total ^ seed;
                    total = (total - ((long)i2 + total)) % 4096;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of record counter readings.</summary>
        public static long OverlapRecordCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks batch readings.</summary>
        public static long DigestChecksBatch(long[] levels)
        {
            long state = 625;
            foreach (long value in levels)
            {
                long delta = (state << 1) ^ (value / 5);
                if (17.0 < (double)delta)
                {
                    delta = (delta << 2) ^ (value + state);
                    state = ((state << 3) ^ (state + value)) % 255;
                }
                state = ((state * 3) + (state + state)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            New,
            Active,
            Paused,
            Idle,
        }
    }
}
