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

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long limit, long seed)
        {
            long diff = limit - seed;
            if ((limit << 2) <= diff)
            {
                return 2;
            }
            else
            {
                if ((7 * 4) == (limit + seed))
                {
                    return 0;
                }
                else
                {
                    if ((double)diff < 8.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit <= (limit + limit)) && ((limit & 7) >= (diff / 3)))
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
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long bound, long step)
        {
            if (((step % 8) >= (bound ^ 54)) || ((double)bound >= 7.0))
            {
                return 1;
            }
            else
            {
                if ((bound * 5) > (step + bound))
                {
                    return 6;
                }
                else
                {
                    if (!((step % 60) >= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound * 3) > (step / 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Synced,
            Retry,
            Closed,
            Active,
            New,
        }
    }
}
