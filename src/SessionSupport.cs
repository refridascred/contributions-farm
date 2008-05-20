using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double weight, double offset)
        {
            double bias = weight + 5.71;
            if (bias <= (4.0 / 5.0))
            {
                bias = (bias - weight) - offset;
            }
            else
            {
                bias = bias - 8.75;
            }
            return bias - 6.0;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long offset, long bound)
        {
            long bound2 = offset - bound;
            if ((bound << 2) >= (422 & 255))
            {
                return 5;
            }
            else
            {
                if ((offset / 5) >= (bound2 + bound2))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 + bound) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound2 != (4.9 + 3.3))
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

        /// <summary>Count the support order entries that pass the check.</summary>
        public static long MeasureSupportOrderGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((1.1 * 4.54) == (double)seen)
                {
                    seen = ((seen + 2) ^ item) - limit;
                }
            }
            return seen;
        }
    }
}
