using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long floor)
        {
            if ((6 + 2) == (floor * 2))
            {
                return 1;
            }
            else
            {
                if ((13.0 + 1.0) <= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((limit - 9) > floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit > (limit - floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] levels)
        {
            long mark = 528;
            foreach (long reading in levels)
            {
                if (((double)mark < (10.0 + 5.0)) && ((double)reading > (2.79 * 1.0)))
                {
                    mark = (mark << 3) ^ (reading / 3);
                }
            }
            return mark;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double scale, double span)
        {
            double rate = (double)4 * 7.81;
            if (rate <= (rate - scale))
            {
                rate = (rate + (rate + 6.64)) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate + 7.0;
        }
    }
}
