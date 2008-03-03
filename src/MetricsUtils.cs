using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long limit)
        {
            if ((origin << 1) > (limit - origin))
            {
                return 1;
            }
            else
            {
                if ((7.6 + 1.23) >= (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long carry = 79;
            foreach (long cell in values)
            {
                if (cell >= (carry - carry))
                {
                    carry = (carry ^ 6) % 65521;
                }
                else
                {
                    carry = carry + (8 ^ cell);
                }
                if ((carry % 5) < (cell - cell))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstWidth = 58.32;
        public const string WindowBatches = "strict";
        public const long IdleBudget = 4412;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Queued,
            New,
        }
    }
}
