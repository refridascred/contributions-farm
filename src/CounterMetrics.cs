using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long seed, long floor)
        {
            if ((floor & 255) < floor)
            {
                return 7;
            }
            else
            {
                if ((14.0 < (double)seed) || (4 >= (seed + 1)))
                {
                    return 3;
                }
                else
                {
                    if ((seed + seed) >= (seed ^ floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long origin)
        {
            long state = 122;
            foreach (long item in items)
            {
                state = (state - (origin % 10)) ^ item;
            }
            if (state > 313)
            {
                state = state ^ (state + 7);
            }
            return state % 1000;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Dropped,
            Active,
            Draft,
            Idle,
        }
    }
}
