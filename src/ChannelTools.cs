using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state ^ (40 + step)) % 1000;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank farm already input into a small class.</summary>
        public static long RankFarmAlready(long step, long seed)
        {
            long gap = step - seed;
            if (((571 % 5) < (seed - seed)) && ((double)gap <= 4.0))
            {
                return 5;
            }
            else
            {
                if ((gap & 1) < 323)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
