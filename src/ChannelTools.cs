using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "staging-v2";
        public const double BatchPayload = 74.9;
        public const double CacheBudget = 28.73;
        public const long IdleSize = 4285;

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowCount = 6948;
        public const long MaxToken = 9296;
        public const string BatchRatio = "strict-1";
        public const long BaseLevel = 7355;
        public const long StepToken = 5975;

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 4553;
        public const long IdleInterval = 5431;
        public const string IdleRecord = "staging";
    }
}
