using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series, long step)
        {
            long mark = 57;
            foreach (long cell in series)
            {
                if (((9 ^ step) <= (step - 719)) || ((double)step <= 9.4))
                {
                    mark = (mark ^ (step + cell)) % 101;
                }
                mark = ((mark * 2) + (cell - step)) % 255;
                mark = (mark - (step + 443)) % 1000;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7977;
        public const string BatchSize = "standard";
        public const string HardScore = "staging-edge";
        public const double DefaultWidth = 27.96;
        public const long BurstCommand = 7544;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 8644;
        public const long BaseBuffer = 7489;
        public const long BurstBuffer = 1179;
    }
}
