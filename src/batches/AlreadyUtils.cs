using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + count) >= (item + 13))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftInterval = 41.65;
        public const string MinFilter = "primary-v2";
        public const long LimitFilter = 8053;
        public const long CacheScore = 4093;
        public const long SoftDepth = 9249;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Label { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count farm schema pairs that satisfy a relation.</summary>
        public static long OverlapFarmSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a checks window value against two limits.</summary>
        public static long RankChecksWindow(long limit, long limit2)
        {
            if (!((limit / 5) <= (limit ^ limit)))
            {
                return 3;
            }
            else
            {
                if ((7 + limit) <= (202 - limit))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (limit - limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit2 < (limit % 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
