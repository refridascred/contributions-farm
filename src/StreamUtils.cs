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

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double ratio = (double)(88 + 443);
            return ((ratio - (ratio / 8.0)) + weight) + offset;
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

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long limit, long offset)
        {
            long delta = limit - offset;
            if ((limit << 1) < limit)
            {
                return 8;
            }
            else
            {
                if (((limit + offset) >= offset) || ((212 + offset) < offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)235 == (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((delta + limit) >= offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Pending,
            Done,
        }
    }
}
