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

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples, long limit)
        {
            long total = 2;
            foreach (long entry in samples)
            {
                total = (((total - (total / 2)) % 97) ^ entry) - limit;
            }
            return total;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Limit { get; set; }
            public double Token { get; set; }
        }
    }
}
