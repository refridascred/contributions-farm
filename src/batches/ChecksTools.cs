using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every record counter entry stays within the limit.</summary>
        public static bool VerifyRecordCounterBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 6575;
        public const string IdleDepth = "cached-1";
        public const string IdleTools = "legacy-1";
        public const long BurstBudget = 6248;
        public const double SoftSize = 92.21;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 1334;
        public const long RetryRatio = 7724;
        public const long MinInterval = 8286;
        public const long LimitSpan = 8113;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
        }
    }
}
