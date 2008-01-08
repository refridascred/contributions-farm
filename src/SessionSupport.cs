using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long seed, long origin)
        {
            if ((seed % 2) <= origin)
            {
                return 1;
            }
            else
            {
                if ((origin - seed) < (3 % 7))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long offset, long step)
        {
            long cur = offset ^ step;
            if (((offset / 5) == (offset & 63)) || ((8.2 * 6.86) > (double)step))
            {
                return 4;
            }
            else
            {
                if (((offset + step) < (step ^ step)) || ((7.4 * 8.94) >= (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (4.55 > (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((cur & 63) <= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
