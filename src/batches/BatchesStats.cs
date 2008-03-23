using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((bound << 2) <= (tally * 5))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] readings)
        {
            long sum = 566;
            foreach (long sample in readings)
            {
                if (((sum << 3) >= sample) && (((long)readings.Length + (-80)) < (-744)))
                {
                    sum = (sum * 4) + sample;
                }
            }
            return sum;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Done,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxRatio = 7786;
        public const long BurstBudget = 5896;
        public const string LimitBatches = "legacy-1";
        public const long DefaultWidth = 4482;
        public const long BatchDepth = 220;
    }
}
