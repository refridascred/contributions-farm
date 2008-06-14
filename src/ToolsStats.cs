using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many cluster session samples are out of range.</summary>
        public static long AuditClusterSessionOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)bound > (6.3 + 7.5))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)origin != (double)anchor)
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Dropped,
            Ready,
        }
    }
}
