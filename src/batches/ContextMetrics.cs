using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleWindow = "staging-edge";
        public const string SoftScore = "alpha";
        public const long StepWindow = 1086;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Pending,
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSize = 2758;
        public const long StepWidth = 1763;
        public const long DefaultCommits = 5126;
        public const long IdleCommits = 6583;

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long step, long bound)
        {
            long delta = step ^ bound;
            if ((double)step == (7.19 - 4.34))
            {
                return 1;
            }
            else
            {
                if (((step % 16) == (delta / 6)) || ((step & 31) >= bound))
                {
                    return 0;
                }
                else
                {
                    if (!((bound + delta) > delta))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta - step) < (delta ^ step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
