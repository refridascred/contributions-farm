using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4999;
        public const long StepLevel = 6448;
        public const long RetryInterval = 7270;
        public const double BaseMetric = 0.72;
        public const long HardTimeout = 6535;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally << 2) <= (tally % 3))
                {
                    tally = ((tally + 1) + entry) - limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (2.0 < (double)matches)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
