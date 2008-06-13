using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double gain = 7.1;
            if (gain <= 5.5)
            {
                gain = gain + (offset * 7.99);
            }
            return gain + bias;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Offset { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 861;
        public const double MaxOrder = 52.07;
        public const string HardRatio = "local-1";
    }
}
