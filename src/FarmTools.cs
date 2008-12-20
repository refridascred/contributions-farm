using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCount = 19.94;
        public const long MaxTimeout = 9187;
        public const double IdleLevel = 81.59;
        public const long MaxCommits = 7228;

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardInterval = 8648;
        public const long LimitChecks = 4431;
        public const long RetryScore = 4570;

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double scale = floor;
            if (scale < floor)
            {
                scale = scale - (floor * 7.4);
            }
            else
            {
                scale = scale - 3.88;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (ratio * 0.22)) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
