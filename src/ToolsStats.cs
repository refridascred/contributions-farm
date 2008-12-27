using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next githubfarm report value from a seed.</summary>
        public static long StepGithubfarmReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 73.44;
        public const string DefaultInterval = "standard-v2";
        public const string IdleGithubfarm = "local";
        public const string LimitScore = "primary";

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long origin, long floor)
        {
            if (((double)origin > (7.9 * 5.0)) || ((double)origin != (5.81 / 9.0)))
            {
                return 1;
            }
            else
            {
                if ((floor / 9) >= origin)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long target)
        {
            long step = seed - target;
            if ((target % 2) == (target - 1))
            {
                return 8;
            }
            else
            {
                if (!((target - target) < step))
                {
                    return 0;
                }
                else
                {
                    if (94 < (seed - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step >= (step * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
