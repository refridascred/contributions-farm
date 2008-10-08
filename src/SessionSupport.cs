using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (3.2 < (double)matches)
                {
                    matches = ((matches + 2) + reading) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long floor)
        {
            long prev = target ^ floor;
            if (((floor * 2) > (floor * 3)) || ((prev - target) >= target))
            {
                return 2;
            }
            else
            {
                if ((prev * 5) > (floor + target))
                {
                    return 4;
                }
                else
                {
                    if (!(2.0 >= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target + target) < (prev + target)) || ((floor * 4) > floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
