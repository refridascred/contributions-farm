using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "standard-edge";
        public const long DefaultPayload = 1408;
        public const double CachePayload = 47.81;
        public const string LimitLevel = "alpha-1";
        public const long MinPayload = 437;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Iterate the stream counter series from a seed.</summary>
        public static long DeriveStreamCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
