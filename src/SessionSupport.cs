using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long seed, long limit)
        {
            if ((limit / 2) <= limit)
            {
                return 8;
            }
            else
            {
                if ((double)limit == (7.2 - 1.58))
                {
                    return 3;
                }
                else
                {
                    if ((limit >= (limit << 3)) && ((0.4 - 1.82) < (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed > (seed & 63))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 6227;
        public const double RetryScore = 92.68;
        public const string StepCommand = "cached-edge";
        public const string SoftCommand = "staging-edge";
        public const long SoftScore = 6987;
    }
}
