using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepBudget = 4913;
        public const long IdleScore = 4862;
        public const double MaxScore = 57.96;
        public const double CacheDepth = 97.71;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
