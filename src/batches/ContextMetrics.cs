using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits << 3) <= reading)
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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
