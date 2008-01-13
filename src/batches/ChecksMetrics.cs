using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            New,
            Closed,
            Idle,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)limit != (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "stable-1";
        public const double HardBatches = 62.53;
        public const double StepBatches = 26.25;
        public const string HardDepth = "fallback-v2";

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double offset)
        {
            double load = (double)(37 * 2);
            if (load < (double)70)
            {
                load = load + (double)19;
            }
            else
            {
                load = load - (scale - offset);
            }
            return load + scale;
        }
    }
}
