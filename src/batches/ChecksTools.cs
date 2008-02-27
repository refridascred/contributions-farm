using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheSize = 6817;
        public const string IdleCount = "latest-edge";
        public const string BurstGraph = "legacy-1";
        public const long DefaultBudget = 3501;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long seed, long target)
        {
            long cur = seed ^ target;
            if (!((seed ^ cur) >= (seed % 60)))
            {
                return 4;
            }
            else
            {
                if ((5.8 < (double)cur) || ((double)seed >= (6.51 / 4.0)))
                {
                    return 7;
                }
                else
                {
                    if ((target - target) < (cur - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the batches channel series from a seed.</summary>
        public static long RollBatchesChannel(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix * 3) + mix;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Pending,
            Active,
        }
    }
}
