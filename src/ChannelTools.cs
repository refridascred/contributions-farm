using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinWidth = "local";
        public const double BurstCount = 49.9;
        public const long StepSize = 7666;
        public const long CacheBuffer = 7071;

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
