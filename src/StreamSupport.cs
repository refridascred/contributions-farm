using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 5652;
        public const long BurstSize = 6263;
        public const double LimitRatio = 77.52;
        public const long MaxBudget = 6521;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 5786;
        public const long BurstCache = 1054;
        public const double IdleCache = 26.91;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
