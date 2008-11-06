using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long seed, long limit)
        {
            long next = seed + limit;
            if ((seed - next) <= (next << 1))
            {
                return 6;
            }
            else
            {
                if (!((limit << 3) != (next + limit)))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 3) != (7 / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((5.7 / 8.0) >= (double)limit) || ((69 / 2) != (seed << 1)))
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

        /// <summary>Define command limits and defaults.</summary>
        public const double StepBudget = 76.51;
        public const long MinRatio = 6083;
        public const long LimitSize = 9506;
        public const long StepCommand = 8762;
        public const long RetryCommand = 1109;

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < (ratio - bias))
            {
                ratio = ratio + (double)90;
            }
            else
            {
                ratio = ratio - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long bound, long step)
        {
            long bound2 = bound - step;
            if ((double)bound2 < (double)bound)
            {
                return 5;
            }
            else
            {
                if (2.49 >= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((2.5 + 5.48) <= (double)total)
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of profile window readings.</summary>
        public static long FoldProfileWindow(long[] values)
        {
            long acc = 615;
            foreach (long cell in values)
            {
                acc = (((acc << 2) ^ acc) % 101) - cell;
            }
            return acc;
        }
    }
}
