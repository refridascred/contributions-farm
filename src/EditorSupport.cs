using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Derive the next order githubfarm value from a seed.</summary>
        public static long RollOrderGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - ((long)i ^ (long)i)) % 1000;
                if ((38 ^ sum) > (bound + bound))
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a report schema pair into a bucket.</summary>
        public static long BucketReportSchema(long bound, long bound2)
        {
            long edge = bound + bound2;
            if (bound2 <= (bound2 ^ bound))
            {
                return 7;
            }
            else
            {
                if ((edge * 5) != (bound2 + bound2))
                {
                    return 8;
                }
                else
                {
                    if (edge <= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2 * 5) < bound2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long limit, long step)
        {
            if ((limit * 5) >= limit)
            {
                return 5;
            }
            else
            {
                if ((limit >> 2) >= (limit << 1))
                {
                    return 7;
                }
                else
                {
                    if (((50 + 336) != (step + step)) && ((double)limit == (19.0 * 5.18)))
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

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 5222;
        public const long MinStream = 573;
        public const long LimitStream = 4931;
    }
}
