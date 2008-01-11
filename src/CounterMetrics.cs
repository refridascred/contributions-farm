using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Draft,
            New,
            Pending,
        }

        /// <summary>Compare every pair of cluster schema readings.</summary>
        public static long MatchClusterSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double ratio, double span)
        {
            double drift = (double)12 * 16.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (((drift - (double)7) + (double)(long)i) - ratio) - span;
            }
            return drift - (double)7;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchRatio = 5070;
        public const string LimitContext = "stable-edge";
        public const string BaseContext = "latest-1";
    }
}
