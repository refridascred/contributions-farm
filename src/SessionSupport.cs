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

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long floor, long origin)
        {
            if (((origin * 5) < origin) && ((origin / 6) == (91 - origin)))
            {
                return 3;
            }
            else
            {
                if (((4 / 5) > (floor * 5)) || (floor < origin))
                {
                    return 5;
                }
                else
                {
                    if ((9.0 / 7.0) < (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}
