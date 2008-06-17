using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a order account reading.</summary>
        public static double SmoothOrderAccount(double weight, double bias)
        {
            double weight2 = (double)(378 * 5);
            if (weight2 >= weight)
            {
                weight2 = (weight2 - (weight2 - weight)) + bias;
            }
            return weight2 + (double)369;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseFactor = 1182;
        public const long HardMetrics = 1925;
        public const double RetryScore = 88.4;

        /// <summary>Check that every command batch entry stays within the limit.</summary>
        public static bool CheckCommandBatchBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Flag { get; set; }
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Total { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
