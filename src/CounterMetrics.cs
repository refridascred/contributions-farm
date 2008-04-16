using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Dropped,
            New,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long limit, long seed)
        {
            long slot = limit + seed;
            if (((limit >> 3) > 9) && ((seed ^ 6) > limit))
            {
                return 7;
            }
            else
            {
                if (slot < (limit >> 5))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of entry cache entries.</summary>
        public static long TallyEntryCache(long[] series, long seed)
        {
            long score = 152;
            foreach (long item in series)
            {
                score = (score ^ item) - seed;
            }
            return score;
        }
    }
}
