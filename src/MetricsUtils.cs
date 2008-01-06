using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long offset)
        {
            if (offset > (step + offset))
            {
                return 4;
            }
            else
            {
                if (((offset ^ (-1)) <= step) && ((offset + offset) > (offset ^ step)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double scale, double bias)
        {
            double bias2 = 1.0 + 5.0;
            return ((bias2 + bias2) + scale) + bias;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long limit)
        {
            if ((step + limit) < limit)
            {
                return 3;
            }
            else
            {
                if (((limit << 1) == (step >> 4)) && (6 >= (limit >> 3)))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) >= (limit - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6 + limit) >= (limit ^ step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
