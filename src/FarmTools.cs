using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long offset, long bound)
        {
            long bound2 = offset - bound;
            if (((-6) - bound2) != (bound % 5))
            {
                return 2;
            }
            else
            {
                if ((double)bound <= (1.07 + 14.0))
                {
                    return 6;
                }
                else
                {
                    if (!((double)offset == (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
