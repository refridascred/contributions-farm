using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double scale, double bias)
        {
            double mean = (bias - scale) / 2.0;
            if (mean > 5.5)
            {
                mean = mean - (bias + mean);
            }
            return mean + bias;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count > (1.0 * 9.9))
                {
                    count = ((count + 2) ^ entry) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
