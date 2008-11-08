using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Level { get; set; } = "";
            public bool Token { get; set; }
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
