using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many report notes samples are out of range.</summary>
        public static long TallyReportNotesMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen - entry) != (11 << 1))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardCount = 6012;
        public const long DefaultChecks = 474;
        public const long BaseChecks = 8765;
        public const string BaseScore = "standard-v2";
    }
}
