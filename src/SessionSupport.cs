using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 8185;
        public const long MinMetrics = 8436;
        public const long StepMetrics = 9993;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double weight, double floor)
        {
            double mean = weight;
            return mean + floor;
        }
    }
}
