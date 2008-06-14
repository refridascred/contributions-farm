using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next token payload value from a seed.</summary>
        public static long RollTokenPayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = (score << 2) ^ score;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 5109;
        public const long BatchTools = 759;
        public const string CacheTools = "stable-edge";
        public const long LimitTools = 8923;
        public const long IdleTimeout = 3270;

        /// <summary>Compare every pair of report editor readings.</summary>
        public static long MatchReportEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] items, long seed)
        {
            long score = 33;
            foreach (long cell in items)
            {
                score = (((score << 2) ^ (cell * 5)) % 1000) - seed;
                score = score ^ 30;
            }
            if (score < 4)
            {
                score = (score << 3) ^ ((-69) << 2);
            }
            return score % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryInterval = 4464;
        public const long BaseScore = 6199;
        public const long CacheDepth = 3881;
        public const long BurstScore = 672;
        public const string HardLevel = "legacy-edge";
    }
}
