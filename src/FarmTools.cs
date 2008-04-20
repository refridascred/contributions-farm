using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 + bias2) - scale;
            }
            return bias2 + (double)7;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long seed, long offset)
        {
            long next = seed ^ offset;
            if ((993 + 44) < offset)
            {
                return 7;
            }
            else
            {
                if (((double)seed >= (14.0 * 7.0)) || ((next / 3) == (seed << 3)))
                {
                    return 2;
                }
                else
                {
                    if (((seed >> 3) > next) || (offset > (6 + seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset & 15) < (50 - seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ tally) >= (origin / 7))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
