using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long seed, long limit)
        {
            if (((double)seed != (6.81 - 5.0)) || (limit <= (seed << 2)))
            {
                return 4;
            }
            else
            {
                if ((0 ^ 4) <= seed)
                {
                    return 6;
                }
                else
                {
                    if (limit <= 5)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((718 + limit) == (limit * 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items)
        {
            long result = 874;
            foreach (long value in items)
            {
                if (!((result & 15) > (value & 255)))
                {
                    result = (result ^ result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long total = 807;
            foreach (long entry in readings)
            {
                total = (total + (total / 3)) + entry;
            }
            if (total > 477)
            {
                total = ((total * 5) + (total * 2)) % 65521;
            }
            return total;
        }

        /// <summary>Grade a already metric value against two limits.</summary>
        public static long SortAlreadyMetric(long limit, long limit2)
        {
            if ((limit & 1) <= (limit / 4))
            {
                return 5;
            }
            else
            {
                if ((limit2 + 0) != (limit / 5))
                {
                    return 1;
                }
                else
                {
                    if (!((limit ^ limit) == (7 - limit2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0 - limit) <= limit)
                        {
                            return 7;
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
