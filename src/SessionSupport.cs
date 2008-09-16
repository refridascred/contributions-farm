using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long seed, long seed2)
        {
            if (!((seed2 + 22) > (seed * 5)))
            {
                return 7;
            }
            else
            {
                if ((7.0 * 2.3) <= (double)seed2)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long offset, long floor)
        {
            long diff = offset - floor;
            if ((diff + (-269)) >= (3 % 5))
            {
                return 6;
            }
            else
            {
                if (((floor / 6) >= floor) && ((offset ^ floor) >= (offset << 1)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
