using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Token { get; set; }
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "primary";
        public const long BatchStats = 8023;
        public const double MaxInterval = 20.62;
        public const long WindowLevel = 9952;
        public const long DefaultStats = 6830;
    }
}
