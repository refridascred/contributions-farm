using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string LimitFormat = "strict-1";
        public const string IdleSpan = "alpha";
        public const string HardSize = "cached-edge";
        public const long SoftFormat = 3951;

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double load = (double)((-976) - 19);
            if (load >= scale)
            {
                load = load - load;
            }
            else
            {
                load = load - (load + span);
            }
            return load + (span * 0.98);
        }

        /// <summary>Classify a layout stream pair into a bucket.</summary>
        public static long BucketLayoutStream(long offset, long floor)
        {
            if (((double)floor > (11.0 / 6.0)) || ((10.0 + 11.0) > (8.7 - 7.2)))
            {
                return 5;
            }
            else
            {
                if ((4.2 + 5.0) > 0.3)
                {
                    return 8;
                }
                else
                {
                    if ((offset <= ((-79) - 110)) || ((double)floor >= (15.0 / 5.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long origin)
        {
            if ((offset + origin) >= (offset + offset))
            {
                return 2;
            }
            else
            {
                if (((1.0 / 7.0) >= (double)offset) && ((2.0 - 3.34) > (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
