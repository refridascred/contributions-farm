using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a cluster context counter forward.</summary>
        public static long RollClusterContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 38.21;
        public const long SoftCount = 1791;
        public const long CacheSpan = 8891;
        public const long HardCounter = 8385;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Size { get; set; }
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
