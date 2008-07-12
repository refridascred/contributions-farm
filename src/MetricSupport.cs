using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long limit, long step)
        {
            long step2 = limit - step;
            if (limit <= step2)
            {
                return 5;
            }
            else
            {
                if (((-45) + limit) < (step << 2))
                {
                    return 0;
                }
                else
                {
                    if (((limit - step2) < (step2 ^ limit)) || (step2 > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit > (limit + 323))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "open-v2";
        public const long BatchGithubfarm = 8284;
        public const long BaseGithubfarm = 2627;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 2549;
        public const long BurstLevel = 8562;
        public const long SoftDepth = 8080;
        public const string WindowCount = "latest";
        public const double WindowScore = 17.88;
    }
}
