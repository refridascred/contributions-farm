using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheTimeout = 3051;
        public const long IdleProfile = 311;
        public const long HardProfile = 7863;
        public const double MaxProfile = 85.66;
        public const long BatchSpan = 9421;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
