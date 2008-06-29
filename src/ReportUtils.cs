using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((5.86 * 8.0) != (double)reading)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double bias = span + (double)5;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + weight) + (double)(long)i;
            }
            return bias - (double)94;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
