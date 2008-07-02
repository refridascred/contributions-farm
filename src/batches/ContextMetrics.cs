using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultScore = 8762;
        public const long BurstCount = 4919;
        public const long MaxFactor = 6259;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] data, long origin)
        {
            long score = -306;
            foreach (long reading in data)
            {
                if (!((score + 286) >= score))
                {
                    score = (score - reading) % 255;
                    score = (score ^ 0) % 97;
                }
                score = score ^ (39 << 3);
                if ((3.0 - 8.52) != (double)origin)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix - mix) % 65521;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            Paused,
            Draft,
            New,
            Stale,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if (1.0 > (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed2 * 4) < (seed2 - diff))
                {
                    return 6;
                }
                else
                {
                    if (!((916 - diff) != (seed + seed2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed > (double)63)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
