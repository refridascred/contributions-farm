using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 4949;
        public const string StepCommits = "staging-1";
        public const long MinCommits = 4151;
        public const double RetryFactor = 51.57;

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples, long seed)
        {
            long result = 9;
            foreach (long reading in samples)
            {
                if (!((double)9 == (double)result))
                {
                    result = (((result ^ result) % 101) - reading) - seed;
                }
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstBudget = "fallback";
        public const string MaxCount = "local";
        public const long WindowDepth = 5904;

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "primary-1";
        public const long MaxChannel = 5172;
        public const string BaseSize = "open-edge";
        public const double HardChannel = 41.97;
        public const long DefaultChannel = 416;
    }
}
