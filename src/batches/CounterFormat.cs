using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((0 << 1) <= ((-18) - hits))
                {
                    hits = ((hits + 2) ^ cell) + target;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series)
        {
            long state = 878;
            foreach (long entry in series)
            {
                state = ((state << 3) ^ (entry - 8)) % 4096;
            }
            if (state > 7)
            {
                state = (state ^ (state & 255)) % 101;
            }
            return state;
        }
    }
}
