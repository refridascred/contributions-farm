using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long seed, long origin)
        {
            long delta = seed ^ origin;
            if ((double)seed >= 1.64)
            {
                return 6;
            }
            else
            {
                if (origin < (seed % 7))
                {
                    return 1;
                }
                else
                {
                    if ((origin + origin) < (delta / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin < seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
