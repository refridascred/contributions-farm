using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 5721;
        public const string MinSession = "cached-v2";
        public const long MaxSize = 1388;

        /// <summary>Roll a entry cache counter forward.</summary>
        public static long DeriveEntryCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                long seen = (bound >> 1) << 3;
                if ((((long)i - bound) < (result << 3)) && (seen >= ((long)i / 9)))
                {
                    seen = ((seen * 2) + ((long)i * 3)) % 1000;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
