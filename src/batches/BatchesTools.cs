using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BaseFactor = 58.33;
        public const long DefaultSupport = 9400;
        public const double BatchBudget = 15.17;
        public const long MaxSupport = 8527;

        /// <summary>Define command limits and defaults.</summary>
        public const double StepInterval = 27.04;
        public const long BurstCommand = 1311;
        public const string MaxCommand = "alpha-edge";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long origin)
        {
            long carry = 6;
            foreach (long cell in values)
            {
                if ((origin > cell) || ((origin >> 2) > (carry + carry)))
                {
                    carry = (carry + cell) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ cell;
                }
            }
            if (carry < 739)
            {
                carry = carry + (origin - origin);
            }
            return carry;
        }
    }
}
