using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count commits batches pairs that satisfy a relation.</summary>
        public static long PairCommitsBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank cache route input into a small class.</summary>
        public static long BucketCacheRoute(long origin, long bound)
        {
            if (((origin + 763) > ((-4) * 4)) && (1.34 < (double)bound))
            {
                return 1;
            }
            else
            {
                if (681 <= (bound - 506))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin) <= 40)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin - origin) >= (origin >> 4)) || ((double)bound <= (3.0 - 5.0)))
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
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((hits >> 1) < ((-24) << 2)))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
