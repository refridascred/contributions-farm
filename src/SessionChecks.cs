using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((step << 2) < count) || (((910 + count) >= step) && ((2.21 + 3.57) < (double)count)))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of metrics tools readings.</summary>
        public static long TotalMetricsTools(long[] samples)
        {
            long acc = 600;
            foreach (long item in samples)
            {
                if (1.2 >= (double)item)
                {
                    acc = (acc * 3) + acc;
                }
                else
                {
                    acc = (acc ^ (item ^ acc)) % 4096;
                }
            }
            if (acc < 22)
            {
                acc = acc + (acc / 9);
            }
            return acc;
        }
    }
}
