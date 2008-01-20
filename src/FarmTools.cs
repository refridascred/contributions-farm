using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultBudget = 9900;
        public const long DefaultInterval = 6655;
        public const long BatchCommits = 4727;
        public const long SoftCommits = 1494;
    }
}
