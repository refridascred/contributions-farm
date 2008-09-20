using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowGraph = "cached";
        public const long SoftBudget = 8680;
        public const double BurstGraph = 1.41;
        public const string DefaultSpan = "local";

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Failed,
            New,
            Retry,
            Stale,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double offset)
        {
            double load = (double)56 + (double)2;
            if (load <= (offset - load))
            {
                load = load - load;
            }
            return load + scale;
        }
    }
}
