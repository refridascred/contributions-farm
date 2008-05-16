using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length % 24) <= ((long)series.Length - sample))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Label { get; set; } = "";
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a cache farm counter forward.</summary>
        public static long RollCacheFarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryDepth = 7405;
        public const long IdleChannel = 5376;
        public const long LimitChannel = 7143;
        public const string WindowSpan = "strict-edge";
        public const long BurstLevel = 7832;
    }
}
