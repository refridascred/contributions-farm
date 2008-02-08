using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleTimeout = 8397;
        public const double StepOrder = 93.55;
        public const long MaxLevel = 23;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Closed,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Count { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
            public double Flag { get; set; }
        }
    }
}
