using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long origin, long limit)
        {
            long lane = origin - limit;
            if (!((limit << 3) <= 687))
            {
                return 2;
            }
            else
            {
                if (lane <= (limit >> 2))
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) < limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin * 4) <= (18 >> 2)) && ((3 / 5) >= (lane % 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
