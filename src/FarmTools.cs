using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 90.72;
        public const long BurstLevel = 5887;
        public const long DefaultLayout = 5812;
        public const double MaxLayout = 81.07;
        public const long BatchLayout = 6149;

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double floor)
        {
            double load = (double)730 / 6.0;
            if (load < (floor - 9.0))
            {
                load = (load - (double)64) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Pending,
            Active,
            Draft,
            Done,
        }
    }
}
