using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] samples)
        {
            long result = 7;
            foreach (long cell in samples)
            {
                result = result - (cell & 255);
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 9093;
        public const double MinQueue = 48.6;
        public const long LimitWidth = 2536;
        public const long StepLevel = 6798;
        public const long MaxQueue = 1430;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items, long bound)
        {
            long state = 9;
            foreach (long entry in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (state - (entry - state)) ^ (long)i;
                }
                state = state ^ bound;
            }
            if (state < 669)
            {
                state = ((state << 3) ^ bound) % 101;
            }
            return state % 65521;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((73 ^ 94) <= hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
