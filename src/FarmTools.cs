using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long seed, long seed2)
        {
            if (((seed2 << 1) >= 61) && ((double)seed < 5.0))
            {
                return 6;
            }
            else
            {
                if (((3.8 * 2.26) <= (double)seed2) || ((583 - seed) != (94 + seed)))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed2 <= (6.92 - 12.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed > (seed2 * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
