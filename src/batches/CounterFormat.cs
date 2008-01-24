using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardRatio = 6653;
        public const string StepOrder = "open";
        public const string BaseTimeout = "alpha-v2";
        public const string RetryOrder = "strict-edge";
        public const double CacheBudget = 37.72;

        /// <summary>Audit batches buffer readings against a rule.</summary>
        public static long CountBatchesBufferHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((tally & 31) >= item))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a commits editor counter forward.</summary>
        public static long IterateCommitsEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 3) ^ ((-9) % 24)) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
