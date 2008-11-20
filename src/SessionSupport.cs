using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowSpan = 49.77;
        public const long RetryCount = 6745;
        public const long MaxSpan = 3812;
        public const long MinSize = 5212;
        public const double BurstEditor = 74.88;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ (limit * 3);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
