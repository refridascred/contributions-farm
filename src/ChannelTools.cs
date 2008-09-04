using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long floor)
        {
            long span = offset - floor;
            if ((span > (offset & 1)) || (span >= (678 + offset)))
            {
                return 3;
            }
            else
            {
                if ((5 << 3) < span)
                {
                    return 5;
                }
                else
                {
                    if (1 > (floor - 263))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long origin)
        {
            if (8.4 < (double)origin)
            {
                return 4;
            }
            else
            {
                if ((origin >= floor) || ((9.1 + 3.62) == (double)floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
