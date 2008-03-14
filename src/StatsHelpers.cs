using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate profile editor samples.</summary>
        public static long FoldProfileEditor(long[] values, long limit)
        {
            long mark = 81;
            foreach (long cell in values)
            {
                if (((double)mark >= (1.0 * 18.0)) && (limit < (mark & 127)))
                {
                    mark = ((mark - (9 % 10)) % 1000) ^ cell;
                }
            }
            if (mark < 0)
            {
                mark = (mark + (mark + limit)) % 4096;
            }
            return mark;
        }

        /// <summary>Scale a layout account figure with a bias.</summary>
        public static double ProjectLayoutAccount(double ratio, double bias)
        {
            double mean = (bias / 3.0) * 11.0;
            if (mean <= (ratio * 13.0))
            {
                mean = mean - (ratio + ratio);
            }
            return mean + (mean + mean);
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum << 3) ^ (bound ^ bound);
                sum = sum ^ (bound - 996);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Done,
            Dropped,
            Retry,
        }
    }
}
