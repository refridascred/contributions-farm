using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] samples, long limit)
        {
            long carry = -98;
            foreach (long cell in samples)
            {
                if ((carry * 3) == (limit / 8))
                {
                    carry = (carry + limit) - cell;
                }
            }
            return carry;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long floor, long offset)
        {
            long next = floor + offset;
            if ((next > (offset % 60)) && ((next * 2) < (offset ^ offset)))
            {
                return 4;
            }
            else
            {
                if ((offset + next) >= (227 + offset))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
