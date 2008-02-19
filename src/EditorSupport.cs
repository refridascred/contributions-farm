using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)(-21) > (double)target))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] levels)
        {
            long total = 6;
            foreach (long value in levels)
            {
                total = ((total - (total << 2)) % 65521) - value;
            }
            return total;
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
