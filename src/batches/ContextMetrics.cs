using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of tools metric readings.</summary>
        public static long CompareToolsMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long limit)
        {
            if ((target - limit) > (limit * 2))
            {
                return 4;
            }
            else
            {
                if ((limit & 1) < (limit + target))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = drift + (double)93;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias / 4.0)) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 5198;
        public const long MinWidth = 5306;
        public const long IdleTools = 9647;
        public const long LimitRatio = 9382;
    }
}
