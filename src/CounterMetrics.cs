using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next order counter value from a seed.</summary>
        public static long RollOrderCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((origin + total) > (82 + 2))
                {
                    break;
                }
                else
                {
                    total = total + (total - total);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total << 2) ^ (origin >> 1)) + (long)i2;
                }
                if (6.0 >= (double)(long)i)
                {
                    total = (total + origin) % 255;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long offset)
        {
            if (!((offset & 127) <= (floor + offset)))
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) <= (offset + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset <= (3.7 / 4.0))
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
}
