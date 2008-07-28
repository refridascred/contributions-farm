using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowRatio = 89.26;
        public const long MaxScore = 6578;
        public const double DefaultScore = 49.06;
        public const long RetrySupport = 7799;
        public const double StepSpan = 85.23;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix << 2) ^ ((long)i - 0)) % 255;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many metrics account samples are out of range.</summary>
        public static long AuditMetricsAccountGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen / 2) < 993)
                {
                    seen = ((seen + 1) + sample) - seed;
                }
            }
            return seen;
        }
    }
}
