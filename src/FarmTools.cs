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

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
