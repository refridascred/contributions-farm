using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryFactor = 2649;
        public const string DefaultBatches = "local-v2";
        public const long SoftInterval = 8996;

        /// <summary>Count stream entry pairs that satisfy a relation.</summary>
        public static long PairStreamEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
