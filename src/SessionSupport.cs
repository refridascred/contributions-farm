using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSpan = 9499;
        public const long SoftBuffer = 371;
        public const string WindowInterval = "local";
        public const long IdleFactor = 510;
        public const double StepLevel = 98.77;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double gain, double span)
        {
            double load = span;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (double)(-77)) + (double)(long)i) + gain;
            }
            return load + load;
        }
    }
}
