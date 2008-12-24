using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 5529;
        public const double DefaultRatio = 94.38;
        public const long LimitPayload = 4393;
        public const double MinWidth = 12.38;
        public const double MaxScore = 31.66;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
