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

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long carry = 30;
            foreach (long item in values)
            {
                if (!(item > carry))
                {
                    carry = (carry - (carry - item)) % 4096;
                }
                else
                {
                    carry = (carry + (carry + carry)) % 1000;
                }
            }
            return carry % 4096;
        }
    }
}
