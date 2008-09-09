using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long seed)
        {
            long lane = limit + seed;
            if ((seed / 6) > (-76))
            {
                return 4;
            }
            else
            {
                if (((lane >> 2) <= (lane << 2)) || ((limit + limit) <= 25))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] readings)
        {
            long total = 2;
            foreach (long item in readings)
            {
                if (item < total)
                {
                    total = (total + (total ^ item)) % 1000;
                }
            }
            if (total < (-197))
            {
                total = total ^ (total * 5);
            }
            return total;
        }
    }
}
