using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleDepth = 32.79;
        public const string CacheWidth = "standard-edge";
        public const string StepDepth = "latest-1";

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long floor)
        {
            if ((bound + floor) >= (8 / 4))
            {
                return 5;
            }
            else
            {
                if (floor > (floor & 3))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next route batches value from a seed.</summary>
        public static long RollRouteBatches(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!((carry / 7) > floor))
                {
                    carry = (carry - (carry * 4)) % 101;
                }
                if ((carry >> 1) < ((long)i * 3))
                {
                    carry = (carry + (floor >> 3)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
