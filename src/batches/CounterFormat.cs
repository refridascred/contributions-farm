using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series, long offset)
        {
            long carry = 129;
            foreach (long entry in series)
            {
                if ((entry <= (700 + offset)) && ((carry & 3) < (offset + 355)))
                {
                    carry = (carry * 3) + 4;
                }
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1737;
        public const long HardFormat = 8230;
        public const long IdleBudget = 2477;

        /// <summary>Look up the position of a counter command sample.</summary>
        public static long LookupCounterCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
