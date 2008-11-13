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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((entry >> 4) >= (entry + (long)readings.Length)) || ((1.2 + 1.8) < (double)entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
