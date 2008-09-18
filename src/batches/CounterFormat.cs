using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up queue order samples.</summary>
        public static long OverlapQueueOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] values)
        {
            long carry = 66;
            foreach (long datum in values)
            {
                if (carry > datum)
                {
                    carry = ((carry << 2) ^ datum) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 97;
                }
                if ((double)datum >= (5.65 + 2.0))
                {
                    carry = ((carry << 3) ^ (3 % 8)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchLevel = 532;
        public const long BaseTimeout = 8047;
        public const long BatchSpan = 4195;
        public const long HardLevel = 3567;
        public const double BaseBatches = 95.8;
    }
}
