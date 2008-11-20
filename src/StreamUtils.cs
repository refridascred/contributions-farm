using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits & 63) < hits) || ((hits & 7) <= (item - 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double ratio, double span)
        {
            double bias = 15.0 * 19.0;
            if (bias > (span - 0.23))
            {
                bias = bias - (double)924;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - ratio) + (double)(long)i;
            }
            return bias - (double)801;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long target, long step)
        {
            long edge = target - step;
            if (!((6.4 - 1.3) <= (double)edge))
            {
                return 7;
            }
            else
            {
                if (!(step >= (edge - step)))
                {
                    return 4;
                }
                else
                {
                    if ((288 << 3) > (step - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target == (double)edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleWidth = 888;
        public const double DefaultTimeout = 85.92;
        public const string CacheCounter = "primary";
        public const double BaseWidth = 3.46;
        public const string IdleRatio = "open-1";

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Pending,
            Done,
        }
    }
}
