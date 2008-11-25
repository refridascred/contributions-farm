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

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitFactor = "staging-v2";
        public const long LimitLevel = 5270;
        public const long StepGraph = 3555;
        public const double HardGraph = 98.77;

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
