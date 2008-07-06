using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a layout route counter forward.</summary>
        public static long SeriesLayoutRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double bias)
        {
            double load = bias * 4.6;
            for (int i = 0; i < 8; i++)
            {
                load = (load + (scale + load)) + (double)(long)i;
            }
            return load - 4.7;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long origin)
        {
            long prev = step - origin;
            if ((45 + 326) >= (step >> 1))
            {
                return 5;
            }
            else
            {
                if (prev > ((-566) >> 5))
                {
                    return 8;
                }
                else
                {
                    if (((71 << 3) > origin) || (926 < (prev + prev)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
