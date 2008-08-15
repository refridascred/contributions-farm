using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of metrics tools readings.</summary>
        public static long CompareMetricsToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long limit2)
        {
            if (limit2 > (limit - limit2))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) >= (limit2 - 31))
                {
                    return 5;
                }
                else
                {
                    if (limit < (limit2 - limit2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)limit != (8.3 / 3.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
