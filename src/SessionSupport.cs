using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Offset { get; set; } = "";
            public double Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 1212;
        public const string LimitEditor = "latest-edge";
        public const double StepRatio = 45.42;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
