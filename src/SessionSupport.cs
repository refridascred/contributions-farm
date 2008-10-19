using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state + (seed % 3)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] series)
        {
            long sum = 294;
            foreach (long value in series)
            {
                if ((sum - sum) < (value ^ sum))
                {
                    sum = (sum - (756 << 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
