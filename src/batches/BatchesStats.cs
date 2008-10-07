using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double bias = 9.0 - offset;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + (double)434) + (double)(long)i) + rate;
            }
            return bias + (double)466;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = (total - (seed << 2)) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
