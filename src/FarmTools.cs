using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchWidth = 6.39;
        public const double HardChannel = 35.23;
        public const double CacheChannel = 62.73;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long target, long floor)
        {
            if ((double)target == (6.0 - 6.32))
            {
                return 1;
            }
            else
            {
                if ((target + target) <= (-8))
                {
                    return 2;
                }
                else
                {
                    if ((floor & 15) == (floor >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - target) > target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry - count) == (3 + (-560))) && (count < (count >> 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
