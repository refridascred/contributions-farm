using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample * 2) < 8)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
