using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm counter value against two limits.</summary>
        public static long RankFarmCounter(long bound, long origin)
        {
            if (origin < (44 & 63))
            {
                return 6;
            }
            else
            {
                if ((0.15 - 7.8) > (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (((-35) > (origin << 1)) || ((origin & 63) <= (94 >> 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin + bound) > bound) && (3 > (bound / 7)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
