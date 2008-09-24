using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 62.98;
        public const string MinDepth = "open-1";
        public const long RetryChannel = 7221;
        public const string BurstSpan = "open-1";
        public const long CacheChannel = 4011;

        /// <summary>Iterate the report channel series from a seed.</summary>
        public static long StepReportChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Size { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseBudget = 6361;
        public const long HardRatio = 4940;
        public const long BurstInterval = 4019;
        public const double BatchSize = 40.55;
        public const long BaseSchema = 9230;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
