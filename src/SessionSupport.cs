using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 4003;
        public const string LimitBudget = "open-v2";
        public const long BaseSession = 7113;
        public const long DefaultFactor = 4842;
        public const long LimitSession = 4590;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Closed,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
