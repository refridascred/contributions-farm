using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double bias = (double)(4 - 527);
            return (bias + (weight + bias)) + floor;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double floor)
        {
            double gain = rate;
            if (gain <= (floor * 8.01))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain - 8.0)) + (double)(long)i;
            }
            return gain + 16.0;
        }

        /// <summary>Rank token buffer input into a small class.</summary>
        public static long BucketTokenBuffer(long step, long seed)
        {
            long offset = step + seed;
            if ((step + offset) >= (step + step))
            {
                return 0;
            }
            else
            {
                if ((seed & 1) >= 0)
                {
                    return 7;
                }
                else
                {
                    if (step <= (70 - seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed < (2.47 + 1.0))
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
        }
    }
}
