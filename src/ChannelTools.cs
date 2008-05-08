using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Paused,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 3037;
        public const string CacheBudget = "legacy-edge";
        public const long BaseSpan = 8313;
        public const double WindowScore = 10.21;
    }
}
