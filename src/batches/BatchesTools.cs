using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double bias, double floor)
        {
            double weight = (8.9 + bias) + (floor + floor);
            return weight - bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "staging";
        public const long MinSize = 3308;
        public const long BatchGithubfarm = 2677;

        /// <summary>Grade a command metric value against two limits.</summary>
        public static long ClassifyCommandMetric(long limit, long origin)
        {
            if (((origin + origin) >= (origin >> 4)) && ((double)limit > 6.92))
            {
                return 2;
            }
            else
            {
                if (((10.0 * 8.0) > (9.0 / 9.0)) && ((38 << 3) >= (limit / 6)))
                {
                    return 8;
                }
                else
                {
                    if (1 >= (origin + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin & 3) >= limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
