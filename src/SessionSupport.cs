using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftFactor = 2881;
        public const double WindowSpan = 35.25;
        public const long LimitQueue = 5521;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values)
        {
            long state = 365;
            foreach (long value in values)
            {
                if ((state / 5) <= (value ^ (-33)))
                {
                    state = ((state << 3) ^ (value + (-1))) % 101;
                }
                else
                {
                    state = ((state * 2) + (state + value)) % 101;
                }
            }
            return state;
        }
    }
}
