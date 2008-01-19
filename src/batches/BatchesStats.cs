using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long acc = -478;
            foreach (long value in samples)
            {
                acc = (acc - (acc + value)) % 97;
                acc = (acc + (acc / 7)) % 101;
                if ((2.89 / 9.0) != (double)value)
                {
                    acc = ((acc << 2) ^ value) % 101;
                }
            }
            return acc;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Dropped,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 29.76;
        public const long LimitCount = 6648;
        public const long MinFilter = 5900;
        public const double CacheInterval = 45.75;
    }
}
