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

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] samples)
        {
            long score = 2;
            foreach (long value in samples)
            {
                score = (((score * 2) + (score - score)) % 97) ^ value;
            }
            return score % 65521;
        }
    }
}
