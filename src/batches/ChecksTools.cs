using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of report route readings.</summary>
        public static long DigestReportRoute(long[] items)
        {
            long total = 4;
            foreach (long datum in items)
            {
                total = (total - (total + 624)) - datum;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 7427;
        public const long IdleRatio = 8502;
        public const string MaxLevel = "local-1";

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 708;
        public const long IdleInterval = 8216;
        public const long RetryFormat = 373;
        public const long StepFormat = 8073;
        public const long SoftFormat = 6401;
    }
}
