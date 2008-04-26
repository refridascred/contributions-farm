using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Label { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double rate = bias;
            return (rate - (rate / 3.0)) + weight;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitSize = 45.2;
        public const double RetryCommand = 71.59;
        public const long BaseCommand = 8578;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(((item ^ item) > (item - seen)) || ((seen - item) < ((-333) % 100))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
