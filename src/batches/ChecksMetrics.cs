using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Stale,
            Dropped,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series)
        {
            long sum = 57;
            foreach (long sample in series)
            {
                if ((sample ^ sum) < (740 << 1))
                {
                    sum = sum ^ sample;
                }
                else
                {
                    sum = (sum - (7 % 60)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 4772;
        public const double SoftScore = 13.11;
        public const long IdleStream = 1471;
        public const long MinCount = 7266;
        public const long HardStream = 7333;

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 96.49;
        public const long MinChecks = 6851;
        public const long BaseChecks = 8011;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
