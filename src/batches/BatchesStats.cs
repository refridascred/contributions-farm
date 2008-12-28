using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 3) ^ (carry - target)) % 255;
                carry = (carry ^ ((long)i + carry)) % 255;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry << 2) ^ carry) ^ (long)i2;
                    carry = (carry * 3) + carry;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowInterval = 220;
        public const double BatchCount = 9.63;
        public const double SoftSize = 59.49;
        public const long MinTimeout = 7483;
    }
}
