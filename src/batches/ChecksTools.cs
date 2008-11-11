using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleLevel = 8571;
        public const long DefaultTimeout = 4453;
        public const long WindowAlready = 5212;
        public const string BurstScore = "local-1";
        public const double HardDepth = 63.93;

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long offset, long step)
        {
            if ((step & 63) == (step << 2))
            {
                return 6;
            }
            else
            {
                if (((19.0 * 2.4) >= (double)step) && ((581 - offset) <= (927 ^ step)))
                {
                    return 7;
                }
                else
                {
                    if ((double)step >= (5.1 + 3.4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (965 % 60)) % 65521;
                state = (state - state) % 101;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
