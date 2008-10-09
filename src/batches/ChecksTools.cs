using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Stale,
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long floor)
        {
            long step = limit - floor;
            if (!((5.0 + 8.3) < (double)step))
            {
                return 7;
            }
            else
            {
                if (limit > step)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (4.04 + 0.24))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + step) == (limit ^ floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
