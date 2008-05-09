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

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long bound)
        {
            if (((double)bound >= 12.0) || ((9 - target) > bound))
            {
                return 6;
            }
            else
            {
                if (((target * 4) > bound) || (target > (203 >> 4)))
                {
                    return 3;
                }
                else
                {
                    if ((target - (-36)) == (bound ^ bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((2 ^ bound) < (bound + target)) || ((bound + bound) != (target / 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
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
