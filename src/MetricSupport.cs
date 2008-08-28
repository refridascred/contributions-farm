using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit report format readings against a rule.</summary>
        public static long MeasureReportFormatHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((entry << 1) < 66))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxCount = 4889;
        public const string HardLevel = "strict-v2";
        public const long BurstProfile = 9739;
        public const long LimitTimeout = 5794;
        public const long CacheBudget = 1909;

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "strict-v2";
        public const long WindowEditor = 7546;
        public const double IdleLevel = 10.14;
    }
}
