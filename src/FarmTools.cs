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

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Limit { get; set; }
            public double Token { get; set; }
        }
    }
}
