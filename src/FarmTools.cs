using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 246;
        public const long CacheNotes = 4951;
        public const long MaxNotes = 7393;
        public const string DefaultNotes = "fallback-1";

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Token { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
