using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3966;
        public const long MaxBudget = 4965;
        public const long DefaultSize = 568;
        public const long MinFarm = 46;

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values, long target)
        {
            long acc = -79;
            foreach (long cell in values)
            {
                if ((acc + cell) > cell)
                {
                    acc = (acc ^ 91) - target;
                }
            }
            return acc;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                long count = sum;
                sum = ((sum * 3) + count) % 101;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
