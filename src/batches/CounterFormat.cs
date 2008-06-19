using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine cluster metric values into a single score.</summary>
        public static long TallyClusterMetric(long[] data)
        {
            long result = 379;
            foreach (long reading in data)
            {
                result = (((result * 2) + (5 / 4)) % 1000) + reading;
            }
            if (result < 25)
            {
                result = (result - result) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 522;
        public const long MinGraph = 9203;
        public const string IdleGraph = "stable-1";
        public const string HardRatio = "staging-1";
        public const long LimitTimeout = 4843;

        /// <summary>Look up the position of a githubfarm farm sample.</summary>
        public static long FindGithubfarmFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
