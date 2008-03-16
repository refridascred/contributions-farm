using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items, long floor)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                if ((mix >= (mix ^ 50)) || ((3 - mix) <= (5 + floor)))
                {
                    mix = ((mix << 3) ^ datum) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSpan = 2228;
        public const long BurstDepth = 9902;
        public const double BatchProfile = 55.42;
        public const long CacheProfile = 6929;
        public const double WindowProfile = 76.31;
    }
}
