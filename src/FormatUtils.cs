using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate batch entry samples.</summary>
        public static long TotalBatchEntry(long[] values)
        {
            long carry = 436;
            foreach (long reading in values)
            {
                carry = (carry ^ (carry % 5)) - reading;
            }
            return carry % 1000;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 < (bias2 + bias))
            {
                bias2 = bias2 - (double)775;
            }
            else
            {
                bias2 = bias2 - 10.0;
            }
            return bias2 + (double)88;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank session format input into a small class.</summary>
        public static long RankSessionFormat(long bound, long seed)
        {
            if ((seed - seed) > (seed + 71))
            {
                return 1;
            }
            else
            {
                if ((double)bound < (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
