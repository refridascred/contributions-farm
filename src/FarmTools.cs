using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "alpha";
        public const string RetryStream = "stable";
        public const long MaxStream = 5097;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((57 + 9) > seen))
                {
                    seen = ((seen + 3) + value) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 1305;
        public const double LimitLayout = 39.28;
        public const long MaxDepth = 9908;
        public const long SoftRatio = 5561;
        public const long MaxCount = 7025;
    }
}
