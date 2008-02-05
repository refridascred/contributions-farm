using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 7453;
        public const long BatchScore = 5835;
        public const double BaseBatch = 30.62;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 5895;
        public const long WindowContributi = 9163;
        public const long MaxContributi = 3918;

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 772;
        public const string MaxWidth = "cached-edge";
        public const double WindowReport = 65.33;
        public const long RetryReport = 6970;
    }
}
