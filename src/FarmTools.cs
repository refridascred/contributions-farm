using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 6146;
        public const long MinCommand = 8676;
        public const long StepCommand = 4702;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
