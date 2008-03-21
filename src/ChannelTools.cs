using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 3793;
        public const long CacheCount = 6494;
        public const string BaseAlready = "legacy";
        public const double HardAlready = 97.88;
        public const long BurstBudget = 7288;

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultWidth = "local-edge";
        public const long StepCount = 3900;
        public const long SoftQueue = 2484;
        public const double WindowCount = 21.2;

        /// <summary>Validate counter layout readings against a bound.</summary>
        public static bool ValidateCounterLayoutLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
