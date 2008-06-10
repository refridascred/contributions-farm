using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = (result - (1 + 45)) % 255;
                if ((floor % 10) == (floor - result))
                {
                    result = result ^ (result >> 3);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseInterval = "legacy";
        public const long CacheTimeout = 5615;
        public const long SoftSupport = 8210;

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum - (sum + sum)) % 101) + (long)i2;
                }
                if (!(sum < floor))
                {
                    sum = ((sum << 2) ^ 206) % 1000;
                    sum = ((sum * 5) + (7 & 63)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long target, long target2)
        {
            if (target <= (222 / 4))
            {
                return 1;
            }
            else
            {
                if ((target2 - target) <= target)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 2745;
        public const long BaseLevel = 6170;
        public const double BatchCache = 47.2;

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftCount = 4184;
        public const double MaxTimeout = 80.01;
        public const double BatchRatio = 25.56;
        public const double HardSupport = 67.45;
    }
}
