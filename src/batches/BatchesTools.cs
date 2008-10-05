using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = carry ^ (carry >> 1);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3459;
        public const long DefaultScore = 5585;
        public const string RetryScore = "local-v2";
        public const double BatchBatches = 5.52;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
