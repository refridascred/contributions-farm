using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftBudget = 5881;
        public const long CacheCommand = 3375;
        public const long MaxCommand = 8620;
        public const long HardBudget = 6683;
        public const long StepCommand = 8680;

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] data, long limit)
        {
            long mark = 33;
            foreach (long item in data)
            {
                mark = mark ^ (limit + item);
            }
            return mark;
        }
    }
}
