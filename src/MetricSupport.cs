using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many report tools samples are out of range.</summary>
        public static long AuditReportToolsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally & 3) != (tally & 31))
                {
                    tally = ((tally + 2) - value) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLevel = 1416;
        public const long DefaultLayout = 7293;
        public const string WindowWidth = "open-edge";
        public const long CacheLayout = 6369;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
