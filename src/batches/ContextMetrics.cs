using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of farm record entries.</summary>
        public static long CombineFarmRecord(long[] readings)
        {
            long result = 57;
            foreach (long sample in readings)
            {
                result = ((result - (5 - 13)) % 65521) - sample;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinFactor = 6966;
        public const double BatchGraph = 64.8;
        public const long BurstGraph = 8781;
        public const long RetryGraph = 5421;
        public const double StepGraph = 62.87;

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data)
        {
            long acc = -2;
            foreach (long cell in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc ^ (long)i) + cell;
                }
                acc = acc + (acc & 1);
            }
            if (acc < 365)
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }

        /// <summary>Combine farm counter values into a single score.</summary>
        public static long WeighFarmCounter(long[] readings, long bound)
        {
            long acc = 740;
            foreach (long reading in readings)
            {
                acc = ((acc - (7 - 165)) + reading) - bound;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Done,
            Ready,
        }
    }
}
