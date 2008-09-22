using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long origin, long step)
        {
            if (((origin % 16) > (origin * 3)) || ((step ^ origin) < (step - origin)))
            {
                return 3;
            }
            else
            {
                if (!((double)step == (5.66 + 2.0)))
                {
                    return 5;
                }
                else
                {
                    if (step < (step - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin ^ 9) >= (step ^ 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            Failed,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "staging-1";
        public const long IdleDepth = 7870;
        public const long MaxBudget = 6614;

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
