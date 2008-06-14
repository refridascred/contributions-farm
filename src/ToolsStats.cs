using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels, long seed)
        {
            long total = -6;
            foreach (long value in levels)
            {
                total = total ^ value;
            }
            if (total > 6)
            {
                total = total ^ (seed % 12);
            }
            return total;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 5109;
        public const long BatchTools = 759;
        public const string CacheTools = "stable-edge";
        public const long LimitTools = 8923;
        public const long IdleTimeout = 3270;

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultInterval = 6874;
        public const long IdleSize = 3387;
        public const string StepContext = "latest";

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchSpan = "standard";
        public const double DefaultTimeout = 55.87;
        public const double RetryStats = 78.43;
        public const long BatchStats = 8231;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            New,
            Idle,
            Ready,
            Active,
        }
    }
}
