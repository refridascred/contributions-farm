using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data, long offset)
        {
            long state = 84;
            foreach (long sample in data)
            {
                if (state <= 62)
                {
                    state = (state * 2) + (offset >> 5);
                }
                if (((double)offset >= 16.0) || ((sample + offset) < sample))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 2387;
        public const long CacheOrder = 7965;
        public const long BatchOrder = 4600;
        public const long StepOrder = 2558;
        public const long DefaultCount = 3303;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
