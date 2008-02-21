using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] levels, long target)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                if ((target + sum) < (target * 4))
                {
                    sum = (sum ^ sum) % 101;
                }
                else
                {
                    sum = sum ^ (322 + reading);
                }
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseRatio = 3464;
        public const long BurstEditor = 6032;
        public const string MaxEditor = "local-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleTimeout = 97.15;
        public const string BurstGraph = "cached-v2";
        public const string CacheLevel = "strict-1";
        public const string BurstScore = "strict-edge";
        public const string DefaultTimeout = "strict-1";

        /// <summary>Classify a support report pair into a bucket.</summary>
        public static long RankSupportReport(long limit, long step)
        {
            long next = limit + step;
            if (next > (48 % 12))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (15.0 + 11.0))
                {
                    return 4;
                }
                else
                {
                    if (next <= (limit + (-56)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((next + step) >= (limit ^ next)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
