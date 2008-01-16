using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long seed, long offset)
        {
            long cur = seed - offset;
            if (((offset * 3) != (offset >> 5)) && ((offset - seed) >= (seed * 5)))
            {
                return 2;
            }
            else
            {
                if (((cur >> 2) <= 28) && (seed < offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed < (2.7 * 0.86))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((cur % 3) == (offset % 10)) || ((703 * 3) < (offset ^ seed)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] series)
        {
            long result = 57;
            foreach (long datum in series)
            {
                result = ((result * 3) + (result - result)) ^ datum;
            }
            return result;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Ready,
            Pending,
            Done,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Failed,
            Dropped,
            New,
        }
    }
}
