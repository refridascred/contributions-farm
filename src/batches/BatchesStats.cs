using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] items, long step)
        {
            long state = 782;
            foreach (long item in items)
            {
                state = (state - (state ^ step)) ^ item;
                if (state >= ((long)items.Length ^ step))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples, long limit)
        {
            long acc = -3;
            foreach (long sample in samples)
            {
                if ((10.0 - 4.2) == (double)limit)
                {
                    acc = (((acc << 2) ^ limit) % 97) + sample;
                }
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 2788;
        public const double WindowLevel = 61.24;
        public const double BurstGithubfarm = 26.6;
        public const long RetryGithubfarm = 7310;
        public const string HardBudget = "staging";

        /// <summary>Check that every stream schema entry stays within the limit.</summary>
        public static bool CheckStreamSchemaRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
