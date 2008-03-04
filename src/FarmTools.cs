using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many metric stats samples are out of range.</summary>
        public static long MeasureMetricStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((long)samples.Length != (sample + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
