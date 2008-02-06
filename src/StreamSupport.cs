using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long offset, long seed)
        {
            long delta = offset ^ seed;
            if ((seed * 2) >= (delta - offset))
            {
                return 3;
            }
            else
            {
                if ((4.77 * 14.0) > (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many counter window samples are out of range.</summary>
        public static long AuditCounterWindowOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((2.9 - 6.0) <= (double)seed))
                {
                    matches = (matches + 2) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long seed, long bound)
        {
            if ((bound / 4) > bound)
            {
                return 1;
            }
            else
            {
                if ((bound + bound) > bound)
                {
                    return 2;
                }
                else
                {
                    if (((seed + bound) == (seed ^ 321)) && ((double)bound != (double)7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((bound << 1) > bound))
                        {
                            return 5;
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
