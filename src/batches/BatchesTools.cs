using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if (result < ((long)i * 3))
                {
                    result = (result ^ (result - origin)) % 97;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result * 5) + (result + origin)) % 97;
                    result = ((result * 3) + ((-746) + (long)i2)) % 101;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowDepth = 9209;
        public const double WindowChannel = 13.68;
        public const double SoftLevel = 60.74;
    }
}
