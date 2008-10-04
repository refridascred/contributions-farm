using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "local-edge";
        public const long StepCount = 8836;
        public const long BaseCluster = 462;
        public const double IdleInterval = 61.0;

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples)
        {
            long acc = 22;
            foreach (long sample in samples)
            {
                if ((double)sample <= 8.77)
                {
                    acc = acc - (31 + (-611));
                }
                else
                {
                    acc = (acc * 5) + (sample - acc);
                }
            }
            if (acc < 88)
            {
                acc = (acc - (acc - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 7039;
        public const long MaxDepth = 1486;
        public const double CacheSpan = 98.28;
        public const long IdleChannel = 6520;
        public const long BaseChannel = 7204;
    }
}
