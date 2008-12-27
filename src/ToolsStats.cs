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

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Stale,
            Retry,
            Queued,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)limit >= 6.0)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
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
