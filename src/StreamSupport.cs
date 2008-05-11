using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double floor)
        {
            double load = weight + floor;
            if (load <= floor)
            {
                load = load + floor;
            }
            return load - (1.86 - weight);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitRatio = 66.27;
        public const long StepCounter = 6216;
        public const double HardCounter = 66.54;

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "staging-1";
        public const long IdleLevel = 4183;
        public const long WindowTimeout = 687;
    }
}
