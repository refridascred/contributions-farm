using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Ready,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowCount = 92.14;
        public const long StepScore = 8540;
        public const long MinRatio = 1694;
        public const long DefaultInterval = 1406;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
