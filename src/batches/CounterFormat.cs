using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank profile schema input into a small class.</summary>
        public static long GradeProfileSchema(long target, long target2)
        {
            if ((double)target2 <= (8.67 / 3.0))
            {
                return 2;
            }
            else
            {
                if (!((target2 % 64) < (target2 ^ 6)))
                {
                    return 5;
                }
                else
                {
                    if (((target << 1) <= (target & 63)) || ((target - target) >= (target2 >> 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target >= (412 * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] items)
        {
            long state = 75;
            foreach (long value in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state - (state ^ 11)) % 101) ^ (long)i;
                    state = (state - (state + 274)) % 101;
                }
                if (973 <= (value ^ value))
                {
                    state = (state + (value - state)) % 65521;
                }
            }
            return state;
        }
    }
}
