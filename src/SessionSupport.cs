using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 57.09;
        public const double BaseWidth = 65.9;
        public const long StepContributi = 9061;
        public const long MinContributi = 7745;
        public const double LimitContributi = 80.23;

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
