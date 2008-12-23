using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!!(0.9 >= (double)reading))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Classify a metric session pair into a bucket.</summary>
        public static long BucketMetricSession(long limit, long floor)
        {
            long gap = limit - floor;
            if ((double)gap <= (9.28 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((double)limit == (double)3)
                {
                    return 6;
                }
                else
                {
                    if (limit <= (limit - (-764)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)gap >= (6.0 - 17.0)))
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

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long target, long bound)
        {
            long next = target - bound;
            if (target >= (next + target))
            {
                return 6;
            }
            else
            {
                if (target >= (next ^ target))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the cache order series from a seed.</summary>
        public static long RollCacheOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = (total << 2) ^ (target << 3);
                total = (total << 2) ^ (total + target);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
