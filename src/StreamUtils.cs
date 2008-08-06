using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item < (18.0 - 0.1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long origin2)
        {
            if (origin2 < (origin * 4))
            {
                return 6;
            }
            else
            {
                if ((815 + origin2) >= (origin - 411))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchTimeout = 2144;
        public const long IdleStats = 9262;
        public const long DefaultInterval = 6360;
        public const string WindowStats = "fallback";

        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchCount = 49.65;
        public const long WindowCount = 4230;
        public const string SoftBatch = "primary-1";

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "local-edge";
        public const long LimitContext = 5476;
        public const long MinContext = 8759;
    }
}
