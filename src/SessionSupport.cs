using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 3924;
        public const string LimitEditor = "cached-v2";
        public const long BaseRatio = 2531;
        public const double WindowInterval = 67.73;

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double scale, double offset)
        {
            double weight = (scale - offset) / 8.0;
            return weight + weight;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
