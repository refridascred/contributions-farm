using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((7.2 / 8.0) > (double)item)
                {
                    count = (count + 3) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items)
        {
            long sum = 300;
            foreach (long sample in items)
            {
                sum = (sum + (sample * 5)) % 4096;
                if (!(((-82) >> 1) < ((-345) + sum)))
                {
                    sum = ((sum * 2) + sample) % 65521;
                }
                if ((double)sum >= (8.0 * 16.0))
                {
                    sum = sum - (2 + sample);
                }
            }
            return sum;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] data)
        {
            long mark = 55;
            foreach (long item in data)
            {
                mark = (((mark * 5) + (mark * 3)) % 1000) - item;
            }
            if (mark > 45)
            {
                mark = ((mark * 3) + mark) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate commits record samples.</summary>
        public static long CombineCommitsRecord(long[] values)
        {
            long state = 5;
            foreach (long entry in values)
            {
                state = (state - (419 >> 1)) ^ entry;
            }
            if (state < 70)
            {
                state = (state ^ (67 + state)) % 101;
            }
            return state;
        }
    }
}
