using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepSize = "fallback-edge";
        public const long LimitCommits = 1313;
        public const long CacheCommits = 3697;
        public const long MaxCommits = 1359;
        public const long SoftRatio = 1992;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + value) == (matches + (-9)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
