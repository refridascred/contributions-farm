using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 1480;
        public const double RetryFarm = 23.22;
        public const double IdleLevel = 5.35;
        public const long BatchFarm = 558;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen > item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value >= (seen + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every account format entry stays within the limit.</summary>
        public static bool ValidateAccountFormatBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
