using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a stats metrics pair into a bucket.</summary>
        public static long ClassifyStatsMetrics(long offset, long seed)
        {
            if (!(seed > offset))
            {
                return 6;
            }
            else
            {
                if ((offset & 255) == (seed ^ 94))
                {
                    return 3;
                }
                else
                {
                    if (!((seed & 1) < (offset + offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (40 <= (seed + 925))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] items, long offset)
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

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryRatio = 42.68;
        public const long MinLevel = 3994;
        public const string DefaultInterval = "stable-1";
        public const double RetryLevel = 93.1;
    }
}
