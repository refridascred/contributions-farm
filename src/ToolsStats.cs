using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double scale = (double)(6 << 1);
            if (scale <= scale)
            {
                scale = scale + (gain * 1.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (6.05 / 3.0)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "staging-v2";
        public const long IdleToken = 5795;
        public const long BatchFactor = 6520;

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 8990;
        public const double RetrySpan = 10.61;
        public const long CacheDepth = 3827;
        public const double WindowLevel = 38.59;
        public const string BatchBatches = "strict-v2";

        /// <summary>Validate contributi payload readings against a bound.</summary>
        public static bool CheckContributiPayloadLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of githubfarm metrics readings.</summary>
        public static long OverlapGithubfarmMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 2138;
        public const string DefaultBatch = "staging-1";
        public const string LimitTimeout = "fallback-1";
    }
}
