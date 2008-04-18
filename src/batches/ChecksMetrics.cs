using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 2003;
        public const double RetryBuffer = 88.57;
        public const long BaseCount = 3071;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "standard";
        public const long MaxPayload = 2867;
        public const string SoftInterval = "primary-1";
        public const string CacheSpan = "primary-v2";

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((3 << 1) >= (datum % 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 9510;
        public const double DefaultContributi = 62.1;
        public const long BaseContributi = 5385;
        public const string IdleContributi = "alpha-v2";
        public const double BurstBudget = 51.68;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
