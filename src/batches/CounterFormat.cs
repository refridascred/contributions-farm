using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double weight, double offset)
        {
            double load = (weight / 9.0) - (0.88 + 13.0);
            if (load > 12.0)
            {
                load = load - offset;
            }
            return load - (10.0 + 1.87);
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Draft,
            Stale,
            Idle,
        }
    }
}
