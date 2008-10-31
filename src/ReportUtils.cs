using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstSize = 6067;
        public const string BaseScore = "local-1";
        public const string MaxFactor = "strict-v2";

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinDepth = "standard-edge";
        public const long MinLayout = 7040;
        public const string DefaultFactor = "latest";
        public const long WindowCount = 8115;
        public const long MinSpan = 4283;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Locked,
            Paused,
        }
    }
}
