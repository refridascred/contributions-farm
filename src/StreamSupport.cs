using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseFactor = "latest";
        public const long BatchWidth = 6482;
        public const long IdleCount = 9770;
        public const double MinChannel = 23.48;
        public const long RetryWidth = 9902;

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
