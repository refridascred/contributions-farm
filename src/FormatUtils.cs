using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a filter cache reading.</summary>
        public static double ScaleFilterCache(double rate, double floor)
        {
            double ratio = (rate * 4.0) / 6.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)16) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (value << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double rate, double floor)
        {
            double scale = rate * 2.8;
            if (scale < floor)
            {
                scale = scale + (rate + scale);
            }
            else
            {
                scale = scale - scale;
            }
            return scale - (1.51 - floor);
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftSize = 2932;
        public const string IdleDepth = "legacy";
        public const long HardRecord = 9301;
        public const string BatchRecord = "strict-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 924;
        public const long BurstWidth = 7743;
        public const long SoftMetric = 9451;
        public const string MaxMetric = "staging";
    }
}
