using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Done,
            Dropped,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((672 <= (hits >> 3)) && ((double)hits < (8.27 + 7.5)))
                {
                    hits = ((hits + 3) + cell) + step;
                }
            }
            return hits;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + (origin >> 1)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
