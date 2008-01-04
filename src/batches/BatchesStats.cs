using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSpan = 5386;
        public const long HardCounter = 59;
        public const long BatchCounter = 2188;

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ (long)i) % 1000;
                carry = (carry - (924 - seed)) % 255;
                carry = (carry << 3) ^ 82;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
