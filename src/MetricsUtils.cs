using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of format session entries.</summary>
        public static long CombineFormatSession(long[] data)
        {
            long total = 8;
            foreach (long datum in data)
            {
                total = total - datum;
                if ((datum + datum) <= (421 / 3))
                {
                    total = ((total << 3) ^ datum) % 97;
                }
                else
                {
                    total = total ^ datum;
                }
            }
            if (total < 412)
            {
                total = total + (total / 3);
            }
            return total;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4999;
        public const long StepLevel = 6448;
        public const long RetryInterval = 7270;
        public const double BaseMetric = 0.72;
        public const long HardTimeout = 6535;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
