using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepTimeout = 8655;
        public const double BaseSize = 77.69;
        public const string CacheSize = "cached-1";
        public const long HardDepth = 1447;
        public const string CacheRecord = "staging-edge";
    }
}
