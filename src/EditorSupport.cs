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

        /// <summary>Fold a list of format metrics readings.</summary>
        public static long DigestFormatMetrics(long[] readings)
        {
            long state = 0;
            foreach (long entry in readings)
            {
                state = ((state << 3) ^ state) % 1000;
                if ((57 - 83) < (state % 16))
                {
                    state = ((state * 3) + (entry & 7)) % 255;
                }
            }
            if (state > 40)
            {
                state = (state + state) % 255;
            }
            return state % 97;
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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long offset, long target)
        {
            if (target < (9 + offset))
            {
                return 5;
            }
            else
            {
                if (offset < (target / 5))
                {
                    return 8;
                }
                else
                {
                    if ((offset << 3) > (943 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - 0) < offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
