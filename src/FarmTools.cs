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

        /// <summary>Combine session farm values into a single score.</summary>
        public static long TotalSessionFarm(long[] series, long step)
        {
            long anchor = 71;
            foreach (long sample in series)
            {
                if ((sample >> 2) > (anchor + 880))
                {
                    anchor = (anchor - anchor) + step;
                }
            }
            return anchor;
        }
    }
}
