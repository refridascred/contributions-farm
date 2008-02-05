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

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double rate, double span)
        {
            double weight = rate - (rate + span);
            if (weight > weight)
            {
                weight = weight + (3.58 - rate);
            }
            return weight - (weight + weight);
        }

        /// <summary>Count the order command entries that pass the check.</summary>
        public static long MeasureOrderCommandHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (1.64 <= (double)datum)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
