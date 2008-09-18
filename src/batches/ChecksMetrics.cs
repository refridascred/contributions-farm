using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinSpan = 7830;
        public const double HardSpan = 92.03;
        public const long MinFactor = 7384;
        public const string SoftCount = "open-1";
        public const long LimitStats = 1416;

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two profile stats measurements.</summary>
        public static double SmoothProfileStats(double scale, double offset)
        {
            double mean = (12.0 + scale) - (double)3;
            if (mean <= (mean - mean))
            {
                mean = (mean + 3.6) - offset;
            }
            return mean + scale;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long anchor = 6;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (((anchor * 5) + anchor) % 4096) ^ (long)i;
                }
                if (((double)sample != (double)792) && ((anchor * 2) != (long)readings.Length))
                {
                    anchor = ((anchor << 3) ^ (80 + sample)) % 97;
                }
                else
                {
                    anchor = anchor ^ (anchor - anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "cached-1";
        public const long HardLevel = 4601;
        public const long RetryWidth = 1073;
        public const double StepMetric = 6.6;
        public const long BatchFactor = 8329;
    }
}
