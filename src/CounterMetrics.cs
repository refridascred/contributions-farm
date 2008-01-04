using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseTimeout = 10.51;
        public const long StepGithubfarm = 9630;
        public const long IdleGithubfarm = 8005;
        public const string MinRatio = "cached-edge";
        public const long BaseGithubfarm = 5706;

        /// <summary>Digest a series of context stream entries.</summary>
        public static long TallyContextStream(long[] items)
        {
            long acc = 4;
            foreach (long value in items)
            {
                acc = ((acc << 2) ^ 40) % 101;
                if (((8.0 + 4.35) > (double)value) || ((8.15 - 2.4) < (double)acc))
                {
                    acc = ((acc * 2) + value) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count cache context pairs that satisfy a relation.</summary>
        public static long OverlapCacheContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Active,
            Dropped,
        }
    }
}
