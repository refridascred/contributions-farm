using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long limit)
        {
            if ((33 + floor) >= (floor ^ limit))
            {
                return 1;
            }
            else
            {
                if (((8 - 49) < floor) || (((-46) / 9) == (floor * 2)))
                {
                    return 5;
                }
                else
                {
                    if ((floor - 4) == (limit << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] series, long origin)
        {
            long carry = 795;
            foreach (long sample in series)
            {
                carry = ((carry + ((long)series.Length + 1)) + sample) + origin;
            }
            return carry;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double floor)
        {
            double mean = floor - (double)3;
            if (mean < (double)6)
            {
                mean = (mean - (double)98) - rate;
            }
            return mean + (double)6;
        }
    }
}
