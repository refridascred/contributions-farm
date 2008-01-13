using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 1078;
        public const long SoftGithubfarm = 9141;
        public const long MinCount = 6900;
        public const string LimitInterval = "alpha";
        public const string BurstGithubfarm = "strict";

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long bound, long step)
        {
            if ((bound * 3) == (step + bound))
            {
                return 0;
            }
            else
            {
                if ((2.4 - 0.6) < (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((bound % 100) == (step * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step << 3) >= bound)
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
    }
}
