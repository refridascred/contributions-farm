using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long sum = 168;
            foreach (long cell in levels)
            {
                sum = (sum * 5) + cell;
                if (6.7 <= (double)cell)
                {
                    sum = (sum * 5) + (cell << 2);
                }
                else
                {
                    sum = (sum + (sum * 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 2807;
        public const double WindowSize = 68.13;
        public const long SoftFactor = 7459;
        public const string HardRecord = "cached-v2";
        public const long WindowSpan = 4883;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Idle,
            Synced,
            Dropped,
            New,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] series)
        {
            long state = 313;
            foreach (long datum in series)
            {
                state = (state + (state >> 5)) + datum;
                if ((7.5 + 8.36) < (8.0 / 5.0))
                {
                    break;
                }
            }
            if (state > 216)
            {
                state = (state * 2) + (state >> 1);
            }
            return state % 4096;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
