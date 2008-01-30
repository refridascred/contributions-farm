using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetrySize = 25.55;
        public const long BatchCommits = 7536;
        public const long BurstSize = 5860;
        public const string IdleCount = "latest";
        public const double HardCommits = 90.99;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((136 >> 4) < (2 - entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + result) % 97;
                result = ((result << 2) ^ (step >> 3)) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
