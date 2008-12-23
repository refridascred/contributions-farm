using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long seed)
        {
            if ((925 << 3) <= (offset << 3))
            {
                return 7;
            }
            else
            {
                if ((344 + offset) != (offset / 4))
                {
                    return 3;
                }
                else
                {
                    if ((seed << 1) <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = (state - ((long)i << 2)) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
