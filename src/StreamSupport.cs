using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowLevel = 1306;
        public const double DefaultContext = 8.37;
        public const long MinWidth = 9622;
        public const double CacheDepth = 4.98;
        public const double StepContext = 76.67;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
