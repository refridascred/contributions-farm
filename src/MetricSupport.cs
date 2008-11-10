using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score * 5) + ((long)i2 - score)) % 1000;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the command counter series from a seed.</summary>
        public static long IterateCommandCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if (state >= (state + floor))
                {
                    state = state + (state >> 2);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Ratio { get; set; }
            public double Label { get; set; }
            public double Total { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
