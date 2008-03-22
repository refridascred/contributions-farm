using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - (acc % 3)) % 101;
                acc = (acc << 3) ^ limit;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] values, long limit)
        {
            long result = 62;
            foreach (long datum in values)
            {
                if ((2 << 1) == (result - datum))
                {
                    result = (result - datum) - limit;
                    continue;
                }
                else
                {
                    result = result + (datum % 10);
                }
                result = result + result;
            }
            return result;
        }

        /// <summary>Classify a stats record pair into a bucket.</summary>
        public static long RankStatsRecord(long step, long limit)
        {
            if ((limit + step) >= step)
            {
                return 5;
            }
            else
            {
                if ((limit % 64) > (limit << 2))
                {
                    return 1;
                }
                else
                {
                    if ((step - step) != (limit & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6.9 * 9.2) >= (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long result = 2;
            foreach (long entry in readings)
            {
                if (!((entry * 5) != ((-9) - result)))
                {
                    result = result + 6;
                }
                else
                {
                    result = result + (0 * 3);
                }
                if ((entry % 5) != (result - 693))
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
