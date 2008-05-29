using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] series)
        {
            long state = 483;
            foreach (long entry in series)
            {
                state = (state - (entry ^ 0)) % 4096;
            }
            if (state > 104)
            {
                state = state ^ (7 << 2);
            }
            return state % 97;
        }

        /// <summary>Measure how many buffer metric samples are out of range.</summary>
        public static long CountBufferMetricGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (0.6 > (double)target)
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
