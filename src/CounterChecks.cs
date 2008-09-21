using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many route profile samples are out of range.</summary>
        public static long CountRouteProfileHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + step) >= (long)items.Length)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((offset - offset) >= (350 - item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryContext = 31.98;
        public const long CacheContext = 3809;
        public const long BaseContext = 2528;

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long offset, long floor)
        {
            if ((offset + floor) <= floor)
            {
                return 2;
            }
            else
            {
                if ((floor / 5) > (floor << 2))
                {
                    return 5;
                }
                else
                {
                    if (6.0 <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many context metrics samples are out of range.</summary>
        public static long AuditContextMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally & 7) >= (tally * 2)))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
