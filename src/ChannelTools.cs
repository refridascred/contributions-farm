using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftWidth = 5120;
        public const long SoftChecks = 8792;
        public const string StepChecks = "legacy";

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSpan = 3168;
        public const double WindowTimeout = 58.94;
        public const long DefaultCount = 6458;

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 4710;
        public const double BaseSize = 1.12;
        public const long MinCount = 6983;
    }
}
