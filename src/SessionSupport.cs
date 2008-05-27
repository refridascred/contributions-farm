using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two format schema measurements.</summary>
        public static double BlendFormatSchema(double gain, double offset)
        {
            double scale = offset;
            if (scale > offset)
            {
                scale = scale - (gain - gain);
            }
            return scale + 8.5;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((origin ^ cell) != (origin / 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long floor, long bound)
        {
            if (((floor ^ bound) <= bound) && ((bound ^ 9) < bound))
            {
                return 4;
            }
            else
            {
                if ((double)floor > (5.49 / 6.0))
                {
                    return 2;
                }
                else
                {
                    if (floor > (bound ^ 79))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - bound) >= (982 ^ floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
