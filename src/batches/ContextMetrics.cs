using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)16 <= (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "strict";
        public const long HardWidth = 2529;
        public const long HardDepth = 6125;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample > (7.06 * 1.1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double rate, double span)
        {
            double load = 9.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load + 6.6) - (double)(long)i;
            }
            return load + (span - rate);
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
