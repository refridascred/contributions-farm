using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 7241;
        public const long StepMetrics = 806;
        public const long HardCount = 8318;
        public const long MaxBudget = 9375;
        public const double HardMetrics = 61.67;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long seed)
        {
            long mix = 0;
            foreach (long datum in data)
            {
                if (7.0 >= (double)mix)
                {
                    mix = ((mix - (datum >> 1)) % 1000) - seed;
                }
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleScore = 5675;
        public const long BurstCommand = 4017;
        public const long BaseTimeout = 120;
        public const long IdleCommand = 5474;
        public const double BaseCommand = 54.5;
    }
}
