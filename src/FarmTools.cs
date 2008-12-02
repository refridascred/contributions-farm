using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8106;
        public const long MinReport = 2168;
        public const long HardReport = 9949;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryScore = 1187;
        public const long CacheBuffer = 274;
        public const long BatchBuffer = 6294;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Total { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
