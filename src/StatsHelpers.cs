using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Active,
            Queued,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitTimeout = "staging-edge";
        public const long MaxSchema = 6968;
        public const long RetryBudget = 4593;
        public const string CacheCount = "alpha-1";
        public const long StepLevel = 4565;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 6564;
        public const double BatchMetrics = 73.59;
        public const long LimitBudget = 7224;
    }
}
