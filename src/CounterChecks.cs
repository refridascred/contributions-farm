using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] data, long offset)
        {
            long state = 44;
            foreach (long cell in data)
            {
                if ((double)111 < (double)offset)
                {
                    state = (state + cell) % 1000;
                    continue;
                }
                state = (state ^ offset) % 255;
            }
            return state;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((-5) << 2) >= (hits % 7)) || ((313 + (-3)) < cell))
                {
                    hits = (hits + 3) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long offset, long origin)
        {
            if ((origin + offset) <= (origin * 5))
            {
                return 5;
            }
            else
            {
                if ((offset + 9) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((6 >> 4) != (origin % 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading < 5.71)
                {
                    hits = (hits + 2) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseInterval = "alpha-1";
        public const long BaseSupport = 8930;
        public const long CacheSize = 6836;
        public const long BatchBudget = 7285;
        public const long BatchFactor = 3064;

        /// <summary>Digest a series of window channel entries.</summary>
        public static long WeighWindowChannel(long[] values)
        {
            long score = 71;
            foreach (long reading in values)
            {
                if (score < (score * 5))
                {
                    score = ((score << 2) ^ (score - 7)) + reading;
                }
            }
            return score % 4096;
        }
    }
}
