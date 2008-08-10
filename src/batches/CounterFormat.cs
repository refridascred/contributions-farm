using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double scale, double offset)
        {
            double weight = (scale / 9.0) + scale;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (scale + weight)) + (double)(long)i) - offset;
            }
            return weight - (double)496;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 6425;
        public const string IdleBudget = "open-1";
        public const long WindowInterval = 4263;
        public const double IdleGithubfarm = 27.16;
        public const long SoftGithubfarm = 396;
    }
}
