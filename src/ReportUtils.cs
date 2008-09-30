using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (4 < (sample ^ 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 8040;
        public const long MaxLevel = 4369;
        public const long LimitAlready = 16;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstFactor = 7135;
        public const double LimitBudget = 73.82;
        public const double MinLevel = 9.01;

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetryRatio = "primary";
        public const double BatchSize = 53.68;
        public const long CacheSchema = 7999;
        public const long StepInterval = 8164;
    }
}
