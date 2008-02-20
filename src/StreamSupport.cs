using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)origin == (double)788)
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 8208;
        public const long BurstInterval = 5227;
        public const long StepSchema = 1534;
        public const string HardFactor = "cached-edge";

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
