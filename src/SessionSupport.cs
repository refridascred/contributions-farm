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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((4 + 469) > count)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
