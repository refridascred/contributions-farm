using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count account schema pairs that satisfy a relation.</summary>
        public static long CompareAccountSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstCount = "fallback";
        public const long HardFactor = 8713;
        public const long BaseContributi = 6062;
        public const string CacheInterval = "fallback";
        public const long BaseInterval = 2041;

        /// <summary>Rank cluster order input into a small class.</summary>
        public static long GradeClusterOrder(long floor, long floor2)
        {
            if (!((7.73 / 2.0) <= (double)floor))
            {
                return 4;
            }
            else
            {
                if (!(floor2 <= (floor * 5)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings)
        {
            long carry = 99;
            foreach (long reading in readings)
            {
                carry = (((carry << 3) ^ (carry ^ carry)) % 101) + reading;
            }
            if (carry < 347)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Check that every filter profile entry stays within the limit.</summary>
        public static bool GuardFilterProfileLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
