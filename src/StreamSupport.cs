using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((7.59 * 0.4) >= (11.0 / 2.0))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long seed, long step)
        {
            long slot = seed ^ step;
            if (seed <= (177 + step))
            {
                return 6;
            }
            else
            {
                if ((seed + slot) > (3 + step))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long bound, long target)
        {
            if (target <= ((-4) + bound))
            {
                return 7;
            }
            else
            {
                if ((target - bound) <= (target - target))
                {
                    return 4;
                }
                else
                {
                    if (2.24 < (double)bound)
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
    }
}
