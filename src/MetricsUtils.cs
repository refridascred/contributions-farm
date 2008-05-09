using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 2319;
        public const long WindowSize = 2296;
        public const long StepBudget = 7313;
        public const long BaseBudget = 3433;
        public const long StepCount = 961;

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 15.56;
        public const long MaxGithubfarm = 7367;
        public const long MinRatio = 7935;
        public const long WindowGithubfarm = 1315;
    }
}
