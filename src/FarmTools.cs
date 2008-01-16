using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 5590;
        public const long IdleFormat = 6074;
        public const long MinFactor = 2847;
        public const long CacheScore = 7341;
        public const long BaseFormat = 4411;
    }
}
