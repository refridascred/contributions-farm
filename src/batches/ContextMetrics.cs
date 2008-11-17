using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheTimeout = 2877;
        public const long MinTimeout = 6803;
        public const double RetryCache = 48.38;
        public const string IdleCache = "primary-v2";

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long bound)
        {
            long diff = step + bound;
            if (!(14.0 < (double)bound))
            {
                return 8;
            }
            else
            {
                if (!((step << 3) > bound))
                {
                    return 1;
                }
                else
                {
                    if (!((step >> 3) <= (bound + diff)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.54 * 7.0) > (double)diff)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BatchCount = "fallback-v2";
        public const long BaseContext = 8768;
        public const long CacheBudget = 7438;

        /// <summary>Check that every graph tools entry stays within the limit.</summary>
        public static bool CheckGraphToolsLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
