using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long limit)
        {
            if ((offset % 10) <= offset)
            {
                return 7;
            }
            else
            {
                if (((limit << 3) == (limit + limit)) && ((offset ^ limit) != (offset * 3)))
                {
                    return 1;
                }
                else
                {
                    if ((5.5 * 5.8) > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a command filter counter forward.</summary>
        public static long DeriveCommandFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((score << 3) > ((long)i / 2)))
                {
                    score = ((score << 3) ^ (score - (long)i)) % 65521;
                }
                score = (score ^ (score / 6)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
