using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a profile layout value against two limits.</summary>
        public static long RankProfileLayout(long seed, long target)
        {
            if ((0.8 - 1.0) == (double)seed)
            {
                return 7;
            }
            else
            {
                if ((target / 2) > (seed & 255))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every order graph entry stays within the limit.</summary>
        public static bool GuardOrderGraphLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
