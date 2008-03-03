using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1657;
        public const double SoftRatio = 47.97;
        public const long BaseRecord = 857;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepSpan = 5952;
        public const string SoftCount = "staging-1";
        public const double DefaultQueue = 10.54;
        public const long BurstQueue = 5289;
        public const long StepDepth = 9401;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
