using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5189;
        public const long BaseCount = 353;
        public const string BurstWidth = "strict-1";

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public double Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a batches command reading by value.</summary>
        public static long LookupBatchesCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
