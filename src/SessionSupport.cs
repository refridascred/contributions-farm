using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 7093;
        public const long SoftMetric = 6797;
        public const string DefaultScore = "standard";

        /// <summary>Measure how many notes commits samples are out of range.</summary>
        public static long CountNotesCommitsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen > 7)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
