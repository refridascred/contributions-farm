using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double rate, double bias)
        {
            double ratio = (double)3;
            if (ratio < (double)762)
            {
                ratio = (ratio + bias) + rate;
            }
            return ratio + (2.0 / 5.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchAccount = "fallback-v2";
        public const double IdleScore = 5.55;
        public const double WindowScore = 39.71;
        public const long CacheSize = 9481;
        public const double StepSize = 44.04;
    }
}
