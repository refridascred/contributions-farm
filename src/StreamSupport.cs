using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Stale,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Rank filter counter input into a small class.</summary>
        public static long SortFilterCounter(long target, long seed)
        {
            long diff = target + seed;
            if ((1.7 + 5.68) > (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed + seed) > (target - 658))
                {
                    return 0;
                }
                else
                {
                    if (!(32 < (diff + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((diff - diff) < (target % 12)) || ((89 - target) >= seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Owner { get; set; }
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
