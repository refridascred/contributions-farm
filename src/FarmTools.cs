using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            New,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 4349;
        public const double BatchTimeout = 67.41;
        public const double BurstLevel = 74.96;
        public const double StepProfile = 4.27;

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double gain, double offset)
        {
            double load = gain;
            if (load < (load * 4.8))
            {
                load = (load + (gain + gain)) + offset;
            }
            return load - (load * 6.93);
        }
    }
}
