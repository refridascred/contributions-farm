using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi entry readings against a bound.</summary>
        public static bool CheckContributiEntryBounds(long[] levels, long bound)
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

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((tally << 1) != (long)readings.Length) && ((double)tally != (8.0 * 2.3)))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Grade a profile session value against two limits.</summary>
        public static long SortProfileSession(long bound, long step)
        {
            long diff = bound + step;
            if (!(40 >= diff))
            {
                return 0;
            }
            else
            {
                if ((bound + step) < diff)
                {
                    return 7;
                }
                else
                {
                    if ((double)step > 1.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((18.0 / 4.0) >= (double)diff) && ((920 - step) == (6 + 89)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((4.4 * 8.92) <= (double)matches)
                {
                    matches = ((matches + 2) ^ datum) - bound;
                }
            }
            return matches;
        }
    }
}
