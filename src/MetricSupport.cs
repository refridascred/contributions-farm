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

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
