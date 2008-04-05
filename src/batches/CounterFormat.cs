using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank account support input into a small class.</summary>
        public static long RankAccountSupport(long seed, long seed2)
        {
            if ((624 / 3) >= seed2)
            {
                return 2;
            }
            else
            {
                if (!((4.73 * 1.8) != (double)seed2))
                {
                    return 8;
                }
                else
                {
                    if ((590 + 0) > seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed ^ seed) > (seed >> 3)) || ((seed * 2) < (seed / 7)))
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

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Stale,
            Draft,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}
