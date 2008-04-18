using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Closed,
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long bound, long limit)
        {
            if ((9.39 + 3.03) <= (double)limit)
            {
                return 7;
            }
            else
            {
                if ((282 << 1) > (bound >> 3))
                {
                    return 0;
                }
                else
                {
                    if ((limit + bound) >= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long offset = score;
                    score = ((score * 2) + offset) ^ (long)i2;
                }
                if (!((limit << 2) <= (limit / 3)))
                {
                    score = (score << 2) ^ (score - limit);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
