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

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] levels, long step)
        {
            long mark = 161;
            foreach (long sample in levels)
            {
                if (((4.3 * 3.0) == (double)mark) && (2 >= mark))
                {
                    mark = (((mark + 1) % 255) - sample) - step;
                }
            }
            return mark;
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
