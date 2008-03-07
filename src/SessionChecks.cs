using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 155;
        public const long StepSpan = 7425;
        public const long BurstFactor = 4753;
        public const double MinFarm = 52.48;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "latest-edge";
        public const long LimitRatio = 2126;
        public const double StepSupport = 85.97;
        public const double RetryLevel = 37.4;
    }
}
