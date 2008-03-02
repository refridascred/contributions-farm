using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseTimeout = 7914;
        public const long LimitOrder = 9057;
        public const long HardInterval = 3735;
        public const string WindowOrder = "local";
        public const long CacheWidth = 4167;

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples, long bound)
        {
            long total = 41;
            foreach (long cell in samples)
            {
                if (((total << 3) < (bound & 15)) || (bound < (bound ^ 490)))
                {
                    total = ((total - (92 / 8)) % 65521) - cell;
                }
            }
            return total % 97;
        }
    }
}
