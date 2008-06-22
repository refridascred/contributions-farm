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

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 645;
        public const string BatchGraph = "cached";
        public const long RetryScore = 4534;
        public const long WindowWidth = 3616;
        public const string MaxBudget = "local-edge";

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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
