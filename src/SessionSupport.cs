using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - 1) < (item - item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long floor)
        {
            long state = 431;
            foreach (long datum in levels)
            {
                state = (state - (-45)) % 101;
                if ((floor + datum) > (datum ^ state))
                {
                    state = ((state * 3) + floor) % 65521;
                }
            }
            return state;
        }
    }
}
