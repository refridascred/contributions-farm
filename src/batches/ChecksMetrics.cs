using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long step, long floor)
        {
            long delta = step + floor;
            if (((delta >> 4) > (step - floor)) || ((delta >> 2) < (step - 386)))
            {
                return 6;
            }
            else
            {
                if ((delta - floor) == (46 * 5))
                {
                    return 3;
                }
                else
                {
                    if (floor > step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long offset)
        {
            if (((offset - offset) > (59 % 12)) && ((bound << 1) < bound))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) <= (9 - bound))
                {
                    return 2;
                }
                else
                {
                    if ((offset - 36) > (bound + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((10.0 * 11.0) >= (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((double)offset <= (5.0 * 18.0))
                {
                    acc = (acc + (32 - acc)) % 101;
                }
                if (((double)acc <= (6.0 + 7.45)) && ((offset - (long)i) <= ((long)i + offset)))
                {
                    acc = (acc ^ (acc / 8)) % 101;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseTimeout = "staging-v2";
        public const string SoftStream = "open-1";
        public const long WindowDepth = 3146;
        public const long IdleScore = 2957;
        public const long CacheStream = 8664;
    }
}
