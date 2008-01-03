using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long floor, long seed)
        {
            if (!((double)floor < (0.84 - 7.5)))
            {
                return 0;
            }
            else
            {
                if (((7 - floor) == (floor + floor)) || ((floor ^ seed) > (815 + floor)))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed <= (14.0 - 0.3)) || (seed <= (149 / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (9.18 >= (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (carry <= step)
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
