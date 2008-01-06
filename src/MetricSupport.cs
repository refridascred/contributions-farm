using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long seed, long offset)
        {
            long step = seed - offset;
            if ((double)offset > (3.0 - 6.0))
            {
                return 5;
            }
            else
            {
                if (offset <= (step + 3))
                {
                    return 0;
                }
                else
                {
                    if (((1 / 8) == (step - offset)) && ((4.68 * 1.4) >= (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset / 4) > (seed + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long limit, long limit2)
        {
            long lane = limit + limit2;
            if ((double)limit2 == (double)lane)
            {
                return 2;
            }
            else
            {
                if (((limit2 % 60) > limit) && ((47 % 10) <= (lane * 5)))
                {
                    return 3;
                }
                else
                {
                    if (((limit2 % 12) != (limit2 + 2)) || ((limit + lane) >= (817 * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
