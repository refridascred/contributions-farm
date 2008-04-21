using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 1379;
        public const string LimitRoute = "stable-1";
        public const double BaseSize = 60.9;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
