using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double gain, double offset)
        {
            double rate = (gain * 8.45) + gain;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (gain + offset)) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Paused,
            Draft,
            Stale,
            Done,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long offset, long seed)
        {
            long span = offset - seed;
            if (((offset + seed) == (offset * 5)) || ((offset / 4) <= (span + offset)))
            {
                return 6;
            }
            else
            {
                if ((seed * 3) == (5 * 5))
                {
                    return 0;
                }
                else
                {
                    if ((0.45 / 7.0) != (double)span)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - span) < (80 + seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
