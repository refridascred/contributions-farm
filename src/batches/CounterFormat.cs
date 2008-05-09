using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long floor, long offset)
        {
            if ((7.1 < (double)offset) && (floor > offset))
            {
                return 7;
            }
            else
            {
                if ((floor * 3) != (floor ^ floor))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 1) == (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor <= (offset & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metrics stream value against two limits.</summary>
        public static long RankMetricsStream(long limit, long seed)
        {
            if ((8.62 - 8.2) == (double)seed)
            {
                return 3;
            }
            else
            {
                if (limit < (76 + limit))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed >= (2.87 / 8.0)) || ((seed + limit) < 37))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >> 5) == (limit ^ 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
