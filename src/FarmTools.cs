using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the order channel entries that pass the check.</summary>
        public static long AuditOrderChannelMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits > (hits % 64))
                {
                    hits = ((hits + 1) ^ sample) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((matches >> 3) != (reading / 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
