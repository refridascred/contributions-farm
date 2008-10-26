using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a session batch pair into a bucket.</summary>
        public static long BucketSessionBatch(long floor, long limit)
        {
            if ((limit * 5) >= limit)
            {
                return 0;
            }
            else
            {
                if (((floor - 27) <= floor) || (513 > (limit - limit)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a route profile figure with a bias.</summary>
        public static double ProjectRouteProfile(double rate, double floor)
        {
            double bias = (double)((-876) + 947);
            if (bias <= (bias - rate))
            {
                bias = (bias - bias) - floor;
            }
            return bias + rate;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long origin, long floor)
        {
            if ((origin < (floor * 5)) && ((double)origin > (9.1 + 2.3)))
            {
                return 4;
            }
            else
            {
                if ((8 + floor) < 1)
                {
                    return 6;
                }
                else
                {
                    if ((origin % 10) > (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (23 < floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
