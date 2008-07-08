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

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Queued,
            Idle,
            Dropped,
            Paused,
        }
    }
}
