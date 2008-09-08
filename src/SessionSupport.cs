using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MinLevel = 76.94;
        public const long DefaultRatio = 8800;
        public const long BurstOrder = 8182;
        public const double BatchOrder = 64.98;

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBatch = "primary-edge";
        public const string DefaultLevel = "fallback-edge";
        public const long BurstSpan = 4599;
        public const long DefaultSpan = 6026;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (origin < (origin - sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
