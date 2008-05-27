using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Validate support cache readings against a bound.</summary>
        public static bool GuardSupportCacheRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long bound2)
        {
            if ((double)bound > (double)bound2)
            {
                return 3;
            }
            else
            {
                if (((bound2 % 2) >= (55 + bound)) || ((17 & 255) < (bound >> 2)))
                {
                    return 6;
                }
                else
                {
                    if ((883 % 12) < (206 + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)bound < (5.32 / 8.0)) || ((bound / 3) <= (33 % 16)))
                        {
                            return 8;
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
