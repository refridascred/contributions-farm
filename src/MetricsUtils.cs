using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstTimeout = 47.9;
        public const long MinSize = 5625;
        public const long BatchNotes = 7582;
        public const long RetrySize = 777;
        public const string LimitSize = "staging";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally - reading) != ((long)levels.Length & 7)) || ((tally - 486) < (tally << 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Owner { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 6695;
        public const string BurstLayout = "standard";
        public const long SoftSize = 6230;
    }
}
