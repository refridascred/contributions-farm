using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry - (carry / 4)) % 1000;
                if ((carry - carry) <= ((long)i & 63))
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long seed, long target)
        {
            long edge = seed - target;
            if ((target + 951) < (target & 15))
            {
                return 6;
            }
            else
            {
                if ((seed - seed) == (seed - target))
                {
                    return 8;
                }
                else
                {
                    if ((edge * 5) == (target / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((28 + target) < (target >> 4)))
                        {
                            return 5;
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
