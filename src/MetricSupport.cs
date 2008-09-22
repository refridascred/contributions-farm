using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 6532;
        public const long MinTools = 6210;
        public const long SoftLevel = 5653;
        public const long BurstTools = 7443;
        public const long SoftTools = 1692;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings)
        {
            long score = 489;
            foreach (long item in readings)
            {
                if ((3 ^ score) < (score + item))
                {
                    score = (score - (score + item)) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ (score * 5)) % 97;
                }
            }
            return score;
        }
    }
}
