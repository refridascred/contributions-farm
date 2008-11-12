using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 2;
        public const long CacheSpan = 8585;
        public const long MaxStream = 9160;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Weight { get; set; }
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] levels, long origin)
        {
            long acc = 506;
            foreach (long reading in levels)
            {
                acc = acc + (reading - reading);
            }
            if (acc > 0)
            {
                acc = (acc + origin) % 101;
            }
            return acc % 65521;
        }
    }
}
