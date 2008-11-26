using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank schema tools input into a small class.</summary>
        public static long BucketSchemaTools(long bound, long step)
        {
            if (198 >= (bound + step))
            {
                return 1;
            }
            else
            {
                if (6 <= (bound + 147))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long seed, long step)
        {
            if ((seed - 375) <= (seed + seed))
            {
                return 2;
            }
            else
            {
                if (((step << 1) < seed) || ((seed - seed) > (seed ^ seed)))
                {
                    return 8;
                }
                else
                {
                    if (((seed % 12) < (step + seed)) || (500 >= (step & 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a buffer cache figure with a bias.</summary>
        public static double AdjustBufferCache(double gain, double floor)
        {
            double scale = (gain - gain) + (floor / 9.0);
            if (scale >= (scale - gain))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (floor / 5.0)) + (double)(long)i;
            }
            return scale + 15.0;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < (weight / 4.0))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (8.7 - bias)) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
