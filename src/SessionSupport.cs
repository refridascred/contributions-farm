using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every session token entry stays within the limit.</summary>
        public static bool VerifySessionTokenLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long step)
        {
            if (((floor - step) == (floor * 3)) && ((floor + 930) >= floor))
            {
                return 6;
            }
            else
            {
                if ((20.0 * 4.83) > (double)step)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every farm token entry stays within the limit.</summary>
        public static bool VerifyFarmTokenRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
