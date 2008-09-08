using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
