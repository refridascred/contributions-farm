using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] series)
        {
            long state = 12;
            foreach (long reading in series)
            {
                if (((state % 24) != (state + state)) && ((395 % 5) < (state * 4)))
                {
                    state = (state - (563 / 9)) ^ reading;
                }
                else
                {
                    state = (state ^ (state - state)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
