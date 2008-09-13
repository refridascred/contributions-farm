using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheBudget = "local";
        public const double BurstNotes = 98.87;
        public const long StepWidth = 9227;
        public const long RetryNotes = 5672;
    }
}
