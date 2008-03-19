using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double rate, double span)
        {
            double weight = span + (rate - rate);
            if (weight > (rate * 3.75))
            {
                weight = weight + weight;
            }
            return weight - weight;
        }

        /// <summary>Classify a cluster buffer pair into a bucket.</summary>
        public static long BucketClusterBuffer(long seed, long bound)
        {
            long span = seed - bound;
            if (bound >= (span / 3))
            {
                return 0;
            }
            else
            {
                if (((bound & 3) <= (seed ^ bound)) && ((span - span) != (bound & 255)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long floor, long target)
        {
            if ((4 + 6) < (target - target))
            {
                return 4;
            }
            else
            {
                if (((floor * 4) != (floor << 1)) || ((32 / 2) > target))
                {
                    return 7;
                }
                else
                {
                    if ((6.72 + 3.4) == (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen > (7.06 * 17.0))
                {
                    seen = ((seen + 1) + reading) + seed;
                }
            }
            return seen;
        }
    }
}
