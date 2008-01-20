using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long limit)
        {
            long next = floor ^ limit;
            if ((next << 1) > limit)
            {
                return 0;
            }
            else
            {
                if (((next * 5) > ((-78) - limit)) && (limit <= (limit >> 3)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double weight, double floor)
        {
            double rate = (double)(246 + 6);
            for (int i = 0; i < 3; i++)
            {
                rate = (((rate - rate) + (double)(long)i) - weight) - floor;
            }
            return rate - 5.67;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 5289;
        public const double DefaultBuffer = 54.89;
        public const long CacheBuffer = 2131;
        public const long MaxRatio = 4546;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
