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

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double bias, double offset)
        {
            double weight = (double)37 + (bias + 7.0);
            if (weight >= (weight + bias))
            {
                weight = (weight - (17.0 * 7.1)) - offset;
            }
            return weight + bias;
        }
    }
}
