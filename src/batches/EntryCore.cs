using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleBudget = "alpha-1";
        public const double IdleSize = 10.18;
        public const long CacheDepth = 4809;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = (score ^ score) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long seed)
        {
            long span = target - seed;
            if (((target * 5) <= (target ^ span)) && ((span ^ seed) > target))
            {
                return 8;
            }
            else
            {
                if (((double)0 >= (double)target) && ((target % 2) >= (span << 1)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) > (37 % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
