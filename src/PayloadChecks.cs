using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the record payload entries that pass the check.</summary>
        public static long MeasureRecordPayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((hits >= entry) && ((entry + hits) <= hits)) || ((entry + hits) >= (hits + entry)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardTimeout = "open";
        public const long StepFactor = 7894;
        public const long StepAlready = 7010;
        public const long BaseBudget = 4510;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long origin)
        {
            if ((double)origin <= (7.7 - 5.9))
            {
                return 6;
            }
            else
            {
                if ((9.53 - 1.66) != (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) <= (origin + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)3 == (double)origin)
                        {
                            return 3;
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
