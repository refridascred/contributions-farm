using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double rate = 7.6;
            return (rate - floor) + ratio;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((entry ^ entry) == ((-5) + entry)) && (tally >= (tally & 15)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
