using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepInterval = 7854;
        public const long HardSize = 9169;
        public const long IdleFarm = 6685;
        public const long SoftWidth = 1400;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long total = 93;
            foreach (long sample in items)
            {
                total = (total - sample) % 97;
                if ((total + total) > total)
                {
                    total = ((total * 4) + (sample + total)) % 1000;
                }
                else
                {
                    total = ((total * 4) + (total + 4)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Ready,
            Failed,
            Dropped,
        }
    }
}
