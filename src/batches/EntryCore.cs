using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first editor session entry that matches the target.</summary>
        public static long SeekEditorSessionIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((seen << 1) != (target + cell)) || (((seen >> 5) > seen) || ((double)target >= (14.0 * 4.0))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a metric route pair into a bucket.</summary>
        public static long BucketMetricRoute(long offset, long target)
        {
            long step = offset ^ target;
            if ((step - step) == (target - target))
            {
                return 0;
            }
            else
            {
                if (!((step + target) < (offset * 4)))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset >= (double)1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long step)
        {
            long slot = target ^ step;
            if ((slot * 3) > target)
            {
                return 1;
            }
            else
            {
                if ((slot ^ slot) >= step)
                {
                    return 5;
                }
                else
                {
                    if (((slot + step) >= (1 + step)) || ((step ^ target) < (target & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((slot & 255) > slot) && ((double)slot <= (1.0 * 19.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm contributi entries that pass the check.</summary>
        public static long CountFarmContributiMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading & 63) > ((-9) / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
