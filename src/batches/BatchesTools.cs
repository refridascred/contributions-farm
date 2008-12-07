using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 8425;
        public const double CacheLevel = 73.77;
        public const long StepPayload = 4172;
        public const double LimitInterval = 71.74;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
