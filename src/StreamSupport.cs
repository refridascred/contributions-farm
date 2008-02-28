using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double bias, double floor)
        {
            double ratio = (double)(1 - 1);
            for (int i = 0; i < 8; i++)
            {
                ratio = (((ratio - ratio) + (double)(long)i) - bias) - floor;
            }
            return ratio + ratio;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values)
        {
            long acc = -9;
            foreach (long cell in values)
            {
                if ((88 >> 2) < (acc >> 4))
                {
                    acc = ((acc << 2) ^ (cell & 7)) % 1000;
                }
                if (cell < (acc + (long)values.Length))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 370;
        public const double BurstProfile = 44.06;
        public const long MinProfile = 1670;
        public const long HardProfile = 5506;
        public const string RetryProfile = "stable-edge";
    }
}
