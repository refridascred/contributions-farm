using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank contributi layout input into a small class.</summary>
        public static long GradeContributiLayout(long seed, long origin)
        {
            if ((double)origin <= (5.3 * 3.8))
            {
                return 4;
            }
            else
            {
                if (((975 - seed) < (origin ^ 8)) || ((628 + 3) == (seed - seed)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long step, long origin)
        {
            if ((double)20 != (double)origin)
            {
                return 4;
            }
            else
            {
                if ((step - origin) < origin)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items)
        {
            long score = 85;
            foreach (long reading in items)
            {
                score = score ^ (score + reading);
                score = (score * 2) + (score << 2);
                if ((double)score < (0.96 / 2.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Locked,
            Dropped,
        }
    }
}
