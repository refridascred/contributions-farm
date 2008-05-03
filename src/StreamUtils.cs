using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitDepth = 1288;
        public const double DefaultBatch = 21.11;
        public const double BurstDepth = 12.7;
        public const long StepFactor = 2694;

        /// <summary>Measure how many window already samples are out of range.</summary>
        public static long AuditWindowAlreadyOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen > 7) || ((origin + 3) == (seen + item))) && ((double)item == (8.7 * 5.73)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 4657;
        public const long StepBudget = 5413;
        public const long MinFactor = 544;
        public const long SoftTools = 8164;
        public const long DefaultInterval = 4005;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Done,
            Locked,
            New,
            Failed,
            Stale,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long mix = 47;
            foreach (long item in levels)
            {
                mix = (mix * 3) + (item & 63);
                if ((mix <= (782 >> 2)) && ((1 >> 2) >= (item - item)))
                {
                    mix = ((mix << 3) ^ item) % 101;
                }
            }
            if (mix > 9)
            {
                mix = (mix + (78 % 5)) % 255;
            }
            return mix;
        }
    }
}
