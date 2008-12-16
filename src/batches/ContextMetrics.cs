using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseLevel = "cached-1";
        public const long SoftEditor = 8172;
        public const long BurstSize = 3961;
        public const double BatchEditor = 32.9;
        public const long BaseEditor = 8162;

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 9501;
        public const string StepSize = "local-v2";
        public const long StepWidth = 6656;
        public const long BaseCount = 1590;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] levels, long seed)
        {
            long anchor = 453;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    long lane = datum;
                    anchor = (anchor - ((long)i + lane)) % 65521;
                }
                anchor = ((anchor * 2) + (datum + seed)) % 65521;
            }
            if (anchor > 694)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }
    }
}
