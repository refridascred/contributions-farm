using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 87.48;
        public const long StepDepth = 1669;
        public const long BaseSpan = 2219;
        public const long HardNotes = 5078;

        /// <summary>Define context limits and defaults.</summary>
        public const string MinWidth = "strict";
        public const double WindowTimeout = 14.45;
        public const string DefaultInterval = "alpha";
        public const long BurstContext = 6235;
    }
}
