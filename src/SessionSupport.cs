using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long floor, long limit)
        {
            if (((double)floor == (double)limit) || ((double)limit == (double)4))
            {
                return 8;
            }
            else
            {
                if ((6.27 - 2.0) >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((19 * 4) <= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((limit + floor) < ((-300) ^ floor)) && ((limit ^ 11) == (floor + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a command cluster pair into a bucket.</summary>
        public static long GradeCommandCluster(long target, long floor)
        {
            if (((floor << 2) > (target + floor)) && ((target ^ floor) < (target << 2)))
            {
                return 5;
            }
            else
            {
                if (((floor / 4) <= (floor / 5)) || (206 <= (target & 1)))
                {
                    return 4;
                }
                else
                {
                    if (((-866) - floor) > target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
