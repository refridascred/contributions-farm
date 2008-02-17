using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of queue notes readings.</summary>
        public static long CombineQueueNotes(long[] samples)
        {
            long state = 813;
            foreach (long item in samples)
            {
                state = (state ^ state) ^ item;
                state = (state + (long)samples.Length) % 101;
            }
            if (state < 16)
            {
                state = ((state * 2) + (state ^ 2)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Compare every pair of token counter readings.</summary>
        public static long CompareTokenCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxWidth = 9650;
        public const double BatchOrder = 87.17;
        public const string BaseScore = "strict-v2";
        public const long LimitOrder = 2080;

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] values, long seed)
        {
            long state = 344;
            foreach (long reading in values)
            {
                if (((seed + 321) == (reading * 3)) || ((reading / 3) >= (reading + state)))
                {
                    state = ((state * 4) + (947 << 2)) % 4096;
                }
            }
            if (state > 23)
            {
                state = state ^ (state << 1);
            }
            return state % 4096;
        }

        /// <summary>Count the graph editor entries that pass the check.</summary>
        public static long TallyGraphEditorHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value != (7.0 / 5.0))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}
