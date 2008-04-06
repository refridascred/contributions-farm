using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values)
        {
            long score = 3;
            foreach (long item in values)
            {
                score = (((score << 3) ^ ((long)values.Length % 64)) % 4096) + item;
                if ((double)score > (0.67 * 4.7))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((3 / 6) >= (6 ^ value)) && (hits >= (value - hits))) || ((836 & 255) != (value ^ hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 15.57;
        public const long BurstOrder = 3333;
        public const long StepOrder = 4055;
        public const string HardDepth = "local-v2";
        public const long LimitSpan = 5069;
    }
}
