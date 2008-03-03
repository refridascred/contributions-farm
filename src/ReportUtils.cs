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

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double weight, double bias)
        {
            double scale = (bias / 5.0) - bias;
            if (scale <= (double)60)
            {
                scale = scale + (double)113;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (scale / 7.0)) + (double)(long)i;
            }
            return scale - weight;
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
