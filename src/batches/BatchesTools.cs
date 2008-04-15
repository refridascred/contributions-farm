using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate entry cluster readings against a bound.</summary>
        public static bool ValidateEntryClusterLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the schema token series from a seed.</summary>
        public static long RollSchemaToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry ^ ((long)i << 2)) % 255;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryBudget = 2844;
        public const long HardRoute = 6582;
        public const long WindowFactor = 8704;
        public const long BaseRoute = 4617;
    }
}
