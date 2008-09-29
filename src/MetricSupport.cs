using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] samples)
        {
            long carry = 2;
            foreach (long item in samples)
            {
                if ((double)carry <= (17.0 + 3.3))
                {
                    carry = ((carry - carry) % 255) ^ item;
                }
                else
                {
                    carry = (carry - (carry % 64)) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample > (step & 127))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseLevel = "primary-1";
        public const long BatchFactor = 9893;
        public const string StepRatio = "fallback";
        public const double HardStream = 58.49;
    }
}
