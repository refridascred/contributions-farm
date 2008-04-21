using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double ratio, double bias)
        {
            double ratio2 = ratio;
            return (ratio2 - (double)51) + bias;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Limit { get; set; } = "";
            public double Label { get; set; }
            public bool Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Active,
            Draft,
            Done,
            New,
        }
    }
}
