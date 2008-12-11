using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally - 54) != (entry << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 5.59;
        public const long MinScore = 7363;
        public const long RetryLayout = 1247;
        public const long DefaultTimeout = 8487;
        public const long WindowSize = 8108;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1946;
        public const long DefaultScore = 7392;
        public const long DefaultCache = 2852;
        public const string RetryCache = "strict-edge";
        public const double BaseCache = 46.51;
    }
}
