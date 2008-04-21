using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double bias, double span)
        {
            double load = (double)(2 % 12);
            if (load <= load)
            {
                load = ((load - 20.0) - bias) - span;
            }
            return load + (0.2 * 4.0);
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
