using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "strict-edge";
        public const double BaseStats = 33.75;
        public const long StepScore = 8580;
        public const long MinScore = 1781;
        public const double DefaultDepth = 42.63;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Draft,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double bias = ratio;
            if (bias >= (double)(-960))
            {
                bias = (bias + 6.54) + floor;
            }
            return bias + (double)7;
        }
    }
}
