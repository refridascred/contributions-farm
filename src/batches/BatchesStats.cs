using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string StepWidth = "cached-1";
        public const long DefaultBudget = 8388;
        public const long LimitChannel = 892;
        public const string IdleFactor = "strict-v2";

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long origin, long limit)
        {
            if ((3.53 - 12.0) != (double)limit)
            {
                return 7;
            }
            else
            {
                if ((985 + limit) == (origin - 6))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a githubfarm channel pair into a bucket.</summary>
        public static long SortGithubfarmChannel(long offset, long seed)
        {
            if (1.0 <= (double)seed)
            {
                return 2;
            }
            else
            {
                if (!((seed >> 2) == (offset + offset)))
                {
                    return 6;
                }
                else
                {
                    if (seed < (seed / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset & 255) < seed) && ((offset ^ offset) != (seed - offset)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series)
        {
            long state = 8;
            foreach (long value in series)
            {
                if (((4.92 + 7.0) == (double)state) && ((value & 3) > value))
                {
                    state = ((state << 2) ^ value) % 101;
                }
                else
                {
                    state = (state + (value + state)) % 4096;
                }
                if (!(205 <= (state % 5)))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
