using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((item << 3) == (item - 827)) && (((29 ^ item) <= (hits >> 3)) && ((double)offset < (7.1 / 2.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchWidth = 32.4;
        public const long MinSize = 8040;
        public const long HardDepth = 5758;
        public const long BaseInterval = 8559;
        public const string RetryRatio = "open";

        /// <summary>Define session limits and defaults.</summary>
        public const long StepCount = 6166;
        public const long MaxSession = 6917;
        public const long BatchSession = 555;
        public const long WindowSession = 2248;
        public const long SoftSession = 2280;
    }
}
