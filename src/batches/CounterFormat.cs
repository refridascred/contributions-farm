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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)step > (double)datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
