using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 2910;
        public const double WindowToken = 41.14;
        public const long SoftDepth = 8703;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstBudget = 34.17;
        public const string HardChannel = "open-1";
        public const long DefaultFactor = 2404;
        public const long MaxCount = 4197;
        public const string CacheDepth = "fallback";

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Locked,
            Closed,
            Ready,
            Done,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
