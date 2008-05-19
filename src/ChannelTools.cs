using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 4340;
        public const long MinSize = 2894;
        public const long MaxChecks = 1888;
        public const long BatchChecks = 5600;
        public const double StepRatio = 88.67;

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }
    }
}
