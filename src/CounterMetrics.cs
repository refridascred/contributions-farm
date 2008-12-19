using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long step, long target)
        {
            if (((8 >> 2) == (step + target)) && ((5.3 / 5.0) < (double)target))
            {
                return 4;
            }
            else
            {
                if ((step >> 3) <= step)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = (state - (state ^ (long)i)) % 4096;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)seen > 11.0)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
