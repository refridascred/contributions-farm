using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long origin, long floor)
        {
            if ((origin < (origin / 4)) || ((origin * 3) > (floor >> 1)))
            {
                return 7;
            }
            else
            {
                if ((2.08 - 3.63) != (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (((floor + origin) != (floor * 3)) || (((-3) - floor) == (origin * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor % 7) <= (619 / 3)) || ((origin << 3) == (floor + floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Stale,
            Pending,
            Active,
            Closed,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
