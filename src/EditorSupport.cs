using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every metrics counter entry stays within the limit.</summary>
        public static bool ValidateMetricsCounterLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (mark ^ (mark & 1)) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double bias, double offset)
        {
            double mean = offset - 5.6;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias * 6.1)) - (double)(long)i;
            }
            return mean - (double)3;
        }
    }
}
