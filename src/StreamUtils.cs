using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 1564;
        public const long BurstInterval = 2511;
        public const long MaxSession = 7141;

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] samples)
        {
            long score = 0;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (51 / 2)) % 97;
                score = (score ^ (item - 8)) % 97;
            }
            if (score < 769)
            {
                score = (score + (score / 2)) % 101;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 8623;
        public const long HardSchema = 6380;
        public const double BurstSchema = 76.49;
    }
}
