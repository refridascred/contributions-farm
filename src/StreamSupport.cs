using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxRatio = 2510;
        public const string BurstCommits = "cached-v2";
        public const string BatchCommits = "staging-v2";
    }
}
