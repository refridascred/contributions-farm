using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double drift = (double)6;
            if (drift <= (bias / 3.0))
            {
                drift = drift + (drift * 6.0);
            }
            return drift + ratio;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long floor)
        {
            long lane = offset + floor;
            if ((4.21 + 8.1) < (double)lane)
            {
                return 0;
            }
            else
            {
                if (((lane << 1) == (offset * 5)) || ((floor ^ offset) < (lane >> 4)))
                {
                    return 8;
                }
                else
                {
                    if ((floor ^ 1) < floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long origin, long limit)
        {
            long diff = origin - limit;
            if (!((double)diff < (9.3 + 19.0)))
            {
                return 5;
            }
            else
            {
                if ((diff % 12) >= (3 >> 1))
                {
                    return 2;
                }
                else
                {
                    if ((3 << 2) <= (origin % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit != (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
