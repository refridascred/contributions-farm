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

        /// <summary>Scale a record cache figure with a bias.</summary>
        public static double AdjustRecordCache(double weight, double floor)
        {
            double drift = floor;
            if (drift < (drift - floor))
            {
                drift = drift + (double)108;
            }
            return drift + weight;
        }

        /// <summary>Digest a series of payload githubfarm entries.</summary>
        public static long TotalPayloadGithubfarm(long[] items)
        {
            long total = 91;
            foreach (long item in items)
            {
                if (total > (item * 4))
                {
                    total = (total - item) % 101;
                }
                if (((76 >> 4) >= (total % 8)) || ((double)item > (9.5 * 5.19)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
