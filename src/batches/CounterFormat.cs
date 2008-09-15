using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a channel metric pair into a bucket.</summary>
        public static long RankChannelMetric(long bound, long origin)
        {
            if (bound < 1)
            {
                return 3;
            }
            else
            {
                if (((origin ^ origin) >= (5 / 2)) && ((bound ^ origin) >= origin))
                {
                    return 0;
                }
                else
                {
                    if ((bound & 127) < (origin & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Idle,
            Stale,
        }
    }
}
