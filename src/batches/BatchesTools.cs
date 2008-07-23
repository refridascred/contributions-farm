using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            New,
            Queued,
            Active,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Done,
            Paused,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 9835;
        public const double WindowBudget = 22.15;
        public const long MaxCount = 6055;
        public const long WindowContributi = 9193;
        public const long WindowSpan = 9098;
    }
}
