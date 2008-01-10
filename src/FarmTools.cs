using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of buffer context readings.</summary>
        public static long CombineBufferContext(long[] samples, long seed)
        {
            long anchor = 37;
            foreach (long datum in samples)
            {
                anchor = (((anchor * 2) + (datum << 3)) % 101) - seed;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 1065;
        public const long CacheBudget = 1413;
        public const long HardOrder = 5520;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Limit { get; set; }
            public double Token { get; set; }
        }
    }
}
