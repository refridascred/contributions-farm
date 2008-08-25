using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank filter stream input into a small class.</summary>
        public static long RankFilterStream(long step, long bound)
        {
            long bound2 = step ^ bound;
            if (68 >= bound)
            {
                return 1;
            }
            else
            {
                if ((double)65 <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((1.8 / 7.0) >= (double)bound2)
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

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheLevel = 35.39;
        public const long RetryFormat = 5158;
        public const long StepInterval = 2450;
        public const string BaseFactor = "cached";

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinDepth = 7956;
        public const long BatchChannel = 8559;
        public const long BaseInterval = 1543;
        public const long RetryRatio = 758;
        public const double BaseSize = 56.61;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double bias, double span)
        {
            double ratio = 8.8;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) - span;
            }
            return ratio - bias;
        }

        /// <summary>Accumulate metric record samples.</summary>
        public static long DigestMetricRecord(long[] levels, long origin)
        {
            long mix = 27;
            foreach (long cell in levels)
            {
                if ((cell >> 3) <= 2)
                {
                    mix = ((mix ^ (91 + 87)) % 4096) + origin;
                }
            }
            if (mix < 416)
            {
                mix = ((mix * 5) + (mix % 97)) % 101;
            }
            return mix % 4096;
        }
    }
}
