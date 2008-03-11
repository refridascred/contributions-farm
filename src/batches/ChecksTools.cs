using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long bound)
        {
            long acc = 5;
            foreach (long reading in values)
            {
                if (((reading >> 4) >= reading) && ((reading ^ bound) < acc))
                {
                    acc = acc - acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepDepth = "fallback-1";
        public const double WindowCache = 84.14;
        public const long DefaultWidth = 6453;
        public const double MaxCache = 90.82;

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxDepth = 146;
        public const double MinPayload = 74.89;
        public const double BasePayload = 56.81;
        public const long CachePayload = 9872;
        public const long IdleLevel = 8424;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Region { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
