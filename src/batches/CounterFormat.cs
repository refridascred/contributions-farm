using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of tools metric readings.</summary>
        public static long CombineToolsMetric(long[] items)
        {
            long acc = 989;
            foreach (long value in items)
            {
                acc = (acc * 2) + (value >> 3);
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "open-edge";
        public const string StepGithubfarm = "fallback-v2";
        public const long MaxWidth = 7850;
        public const double DefaultLevel = 89.1;

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
