using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Draft,
            Closed,
            Ready,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleWidth = "staging-edge";
        public const double WindowFilter = 22.9;
        public const long IdleFilter = 5000;
        public const long StepDepth = 7480;
        public const long HardFilter = 1877;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
