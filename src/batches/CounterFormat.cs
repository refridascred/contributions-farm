using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long floor, long step)
        {
            long diff = floor ^ step;
            if ((floor - step) <= (floor & 63))
            {
                return 1;
            }
            else
            {
                if (((44 / 6) < (step + 6)) || (step > (diff - step)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] levels, long step)
        {
            long score = -9;
            foreach (long cell in levels)
            {
                score = ((((score * 2) + score) % 4096) + cell) + step;
            }
            return score;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
