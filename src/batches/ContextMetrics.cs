using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate batches already readings against a bound.</summary>
        public static bool ValidateBatchesAlreadyRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long step, long target)
        {
            if (target < (step - step))
            {
                return 6;
            }
            else
            {
                if ((step + 3) >= (target % 10))
                {
                    return 1;
                }
                else
                {
                    if ((9 + target) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double scale = 2.94;
            if (scale <= scale)
            {
                scale = ((scale - (scale / 2.0)) + rate) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (1.3 * 0.21);
        }
    }
}
