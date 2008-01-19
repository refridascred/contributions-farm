using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (2.7 < (double)(long)levels.Length)
                {
                    count = ((count + 3) + cell) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series, long step)
        {
            long mark = 6;
            foreach (long reading in series)
            {
                if (mark <= (reading / 6))
                {
                    break;
                }
                if (!((9.18 - 2.64) <= (double)step))
                {
                    mark = ((mark << 3) ^ 719) % 65521;
                }
                if (((reading >> 2) >= ((-3) / 9)) && ((3.8 + 7.3) <= (double)step))
                {
                    break;
                }
            }
            if (mark > 5)
            {
                mark = ((mark * 5) + step) % 4096;
            }
            return mark;
        }
    }
}
