using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (seen <= (seen - value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double span)
        {
            double drift = weight;
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - span;
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
