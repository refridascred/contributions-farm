using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((step + (-37)) >= (count & 63))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 1949;
        public const long RetrySpan = 5285;
        public const string BatchQueue = "legacy-edge";
        public const string WindowQueue = "standard-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultLevel = 23.46;
        public const long CacheStream = 8186;
        public const string HardTimeout = "latest";
    }
}
