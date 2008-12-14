using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every cluster checks entry stays within the limit.</summary>
        public static bool GuardClusterChecksRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 4928;
        public const long CacheSession = 8028;
        public const long MaxSize = 3336;
        public const long BurstDepth = 6310;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
