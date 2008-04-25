using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinTimeout = 5472;
        public const long StepProfile = 8193;
        public const long DefaultProfile = 5955;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of commits support entries.</summary>
        public static long TallyCommitsSupport(long[] samples, long bound)
        {
            long anchor = 5;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (anchor + anchor)) % 101) - cell;
            }
            if (anchor < 915)
            {
                anchor = ((anchor * 3) + bound) % 97;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftSize = "fallback-v2";
        public const long StepRecord = 1421;
        public const long BurstRecord = 4233;
        public const long MinRecord = 2879;
        public const string LimitLevel = "stable-edge";
    }
}
