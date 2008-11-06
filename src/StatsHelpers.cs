using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((89 >> 3) >= (offset ^ hits)) || ((hits - 380) == (offset / 6)))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long step, long floor)
        {
            if (((double)step != (4.58 / 8.0)) && ((step + step) < (2 * 5)))
            {
                return 6;
            }
            else
            {
                if ((13.0 - 1.0) <= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step - 40) >= (669 ^ floor))
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

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
