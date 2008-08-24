using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a command metrics value against two limits.</summary>
        public static long SortCommandMetrics(long offset, long limit)
        {
            if ((offset + (-678)) > 342)
            {
                return 2;
            }
            else
            {
                if ((double)limit < (11.0 - 3.42))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset == (4.67 / 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double offset)
        {
            double drift = scale;
            return (drift - scale) + offset;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
