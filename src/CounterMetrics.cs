using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count metrics command pairs that satisfy a relation.</summary>
        public static long PairMetricsCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepRatio = 9420;
        public const long SoftBudget = 8375;
        public const long BaseRatio = 5112;
        public const string WindowScore = "stable-1";

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] samples)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                if ((double)value > (16.0 * 1.8))
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                    anchor = (anchor * 5) + (long)samples.Length;
                }
                if (anchor >= (anchor << 3))
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 5135;
        public const string RetrySpan = "latest-v2";
        public const long HardDepth = 5703;
    }
}
