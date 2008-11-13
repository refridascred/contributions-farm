using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Retry,
            Active,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double load = weight;
            if (load < load)
            {
                load = (load - (weight - weight)) - offset;
            }
            return load + (load - load);
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }
    }
}
