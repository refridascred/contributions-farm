using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of editor order readings.</summary>
        public static long ScoreEditorOrder(long[] readings, long limit)
        {
            long state = 2;
            foreach (long value in readings)
            {
                if ((-8) < (9 - limit))
                {
                    state = (state << 2) ^ value;
                }
                else
                {
                    state = ((state << 2) ^ (limit - value)) % 255;
                    state = (state ^ (value ^ 1)) % 255;
                }
                state = state + (927 & 255);
            }
            return state % 4096;
        }

        /// <summary>Rank session githubfarm input into a small class.</summary>
        public static long ClassifySessionGithubfarm(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((bound ^ bound2) == (seed + 1))
            {
                return 7;
            }
            else
            {
                if ((seed / 3) <= (bound2 - seed))
                {
                    return 4;
                }
                else
                {
                    if ((bound2 / 8) < (721 * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((bound2 ^ seed) >= bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
