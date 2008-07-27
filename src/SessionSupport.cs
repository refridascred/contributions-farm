using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many token farm samples are out of range.</summary>
        public static long MeasureTokenFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits > 5.0)
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the report account entries that pass the check.</summary>
        public static long TallyReportAccountMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!!(seed >= (seed + 65)))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
