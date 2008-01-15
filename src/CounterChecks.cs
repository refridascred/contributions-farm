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

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] readings)
        {
            long acc = 302;
            foreach (long item in readings)
            {
                if ((item << 2) != (67 % 3))
                {
                    acc = ((acc << 3) ^ (item << 2)) % 97;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits <= (0.12 + 3.6))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
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
