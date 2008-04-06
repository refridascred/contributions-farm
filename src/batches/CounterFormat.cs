using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double ratio, double floor)
        {
            double mean = (double)(119 - 166);
            if (mean <= 3.4)
            {
                mean = ((mean + (mean * 11.0)) - ratio) - floor;
            }
            return mean + (double)83;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 9552;
        public const long DefaultRatio = 9044;
        public const string StepEditor = "open-edge";
        public const long IdleEditor = 1606;
        public const double HardScore = 6.98;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long floor, long origin)
        {
            if (floor >= (5 * 2))
            {
                return 4;
            }
            else
            {
                if (floor < origin)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
