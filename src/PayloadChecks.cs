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

        /// <summary>Digest a series of graph buffer entries.</summary>
        public static long ScoreGraphBuffer(long[] data, long offset)
        {
            long acc = 869;
            foreach (long entry in data)
            {
                if ((5.14 + 4.99) != (double)entry)
                {
                    acc = ((acc + (entry + acc)) % 101) + offset;
                }
            }
            return acc;
        }

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

        /// <summary>Audit stats metrics readings against a rule.</summary>
        public static long TallyStatsMetricsGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((double)item == (7.0 * 5.8)) || (item <= 108)))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 5392;
        public const long DefaultChannel = 8700;
        public const long HardTimeout = 3636;
    }
}
