using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Queued,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchSpan = 7902;
        public const long MinChannel = 634;
        public const double StepChannel = 38.45;
        public const long BaseChannel = 4982;
        public const string BurstCount = "open-v2";

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long floor, long offset)
        {
            long next = floor ^ offset;
            if (!(offset > (4 >> 4)))
            {
                return 0;
            }
            else
            {
                if ((offset - offset) <= next)
                {
                    return 3;
                }
                else
                {
                    if ((floor / 2) <= (floor + (-2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long origin, long target)
        {
            if ((origin - target) != (origin & 1))
            {
                return 8;
            }
            else
            {
                if (origin <= (target & 1))
                {
                    return 4;
                }
                else
                {
                    if ((origin - origin) >= (target % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target <= (origin + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] items, long limit)
        {
            long mix = 76;
            foreach (long value in items)
            {
                mix = (((mix * 5) + 6) + value) - limit;
            }
            return mix;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            Active,
            Locked,
            Pending,
            Synced,
        }
    }
}
