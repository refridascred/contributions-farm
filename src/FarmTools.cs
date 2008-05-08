using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 6145;
        public const long BatchRecord = 4488;
        public const long SoftRecord = 5871;

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 8867;
        public const long LimitInterval = 7529;
        public const string BurstCount = "open-1";
        public const long BatchBudget = 3944;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
        }
    }
}
