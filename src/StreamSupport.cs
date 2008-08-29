using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2604;
        public const long HardWindow = 4393;
        public const long LimitScore = 9174;
        public const long RetryWindow = 6450;
        public const string StepWindow = "latest-1";

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double load = rate / 5.0;
            return (load - rate) + span;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepBudget = 15.18;
        public const double BatchFactor = 7.39;
        public const long BatchContributi = 1392;
        public const long BaseContributi = 2375;
        public const long BaseWidth = 4590;
    }
}
