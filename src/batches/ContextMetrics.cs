using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long seed)
        {
            long bound = offset ^ seed;
            if ((seed - bound) < (bound + seed))
            {
                return 4;
            }
            else
            {
                if (seed >= (seed + offset))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long seed, long step)
        {
            if (((step + seed) == (seed * 5)) && ((3 + seed) <= (22 / 8)))
            {
                return 6;
            }
            else
            {
                if (!((double)seed == (4.3 + 6.0)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a metric schema reading by value.</summary>
        public static long FindMetricSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            Done,
            Closed,
            Pending,
            New,
        }
    }
}
