using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long bound, long target)
        {
            if ((target - 15) > (bound + target))
            {
                return 8;
            }
            else
            {
                if (((double)bound < (double)target) || (bound <= (bound + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((834 << 3) != (bound ^ target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound > (bound + (-58)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long bound, long floor)
        {
            long next = bound ^ floor;
            if (floor > (floor & 15))
            {
                return 4;
            }
            else
            {
                if ((floor < (bound * 2)) && (floor < (bound % 2)))
                {
                    return 3;
                }
                else
                {
                    if (bound < (2 + 96))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((next + floor) <= bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
