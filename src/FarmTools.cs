using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Active,
            Synced,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 1356;
        public const long HardLevel = 3643;
        public const long WindowLevel = 5310;
        public const long BatchMetric = 117;

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double gain, double offset)
        {
            double drift = offset;
            if (drift > (drift * 2.0))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (double)4;
            }
            return drift + gain;
        }
    }
}
