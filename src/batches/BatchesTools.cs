using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultFarm = 93.38;
        public const long MinFarm = 3029;
        public const double MinLevel = 4.76;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Queued,
            Stale,
            Failed,
            Pending,
        }
    }
}
