using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series)
        {
            long state = 1;
            foreach (long cell in series)
            {
                if ((406 - state) >= cell)
                {
                    state = state + (state << 3);
                }
            }
            return state % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchBudget = 1376;
        public const long HardSize = 244;
        public const string BurstQueue = "latest-1";
        public const double MinTimeout = 51.98;
        public const long DefaultRatio = 2996;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
