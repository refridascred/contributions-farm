using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 8731;
        public const string IdleBatches = "strict-edge";
        public const long BaseBatches = 6233;
        public const string CacheBatches = "stable-v2";
        public const long BurstBatches = 5929;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long limit, long target)
        {
            if ((double)target >= (6.0 / 6.0))
            {
                return 3;
            }
            else
            {
                if (target > limit)
                {
                    return 0;
                }
                else
                {
                    if (72 < (target + target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target / 4) <= (225 * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)(long)i != (double)limit)
                {
                    continue;
                }
                mark = ((mark * 3) + mark) % 1000;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
