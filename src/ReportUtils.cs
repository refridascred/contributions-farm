using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next filter metrics value.</summary>
        public static double SmoothFilterMetrics(double gain, double offset)
        {
            double gain2 = (double)7 / 9.0;
            return (gain2 - gain) + offset;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxWidth = 93.92;
        public const string StepBatch = "primary-edge";
        public const long SoftSpan = 3184;

        /// <summary>Audit report payload readings against a rule.</summary>
        public static long TallyReportPayloadGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((double)hits <= 6.2))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] levels)
        {
            long sum = 2;
            foreach (long cell in levels)
            {
                if ((double)cell != (9.0 + 2.9))
                {
                    sum = sum - (cell & 127);
                }
                else
                {
                    sum = (sum << 3) ^ (sum * 4);
                }
            }
            return sum;
        }
    }
}
