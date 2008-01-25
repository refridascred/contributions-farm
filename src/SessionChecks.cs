using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double span)
        {
            double bias = (span + span) / 3.0;
            return (bias - (span / 2.0)) + scale;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "alpha-v2";
        public const long WindowDepth = 514;
        public const long DefaultPayload = 2175;
        public const double IdleBudget = 63.82;
    }
}
