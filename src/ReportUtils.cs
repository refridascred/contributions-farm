using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a farm command reading by value.</summary>
        public static long LookupFarmCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstCount = "strict";
        public const double CacheBudget = 59.96;
        public const long DefaultCount = 3522;
        public const double MinRatio = 91.66;

        /// <summary>Blend two batch format measurements.</summary>
        public static double ScaleBatchFormat(double bias, double span)
        {
            double bias2 = (double)(4 * 3);
            if (bias2 <= bias2)
            {
                bias2 = (bias2 + (4.0 * 4.6)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + 2.1) + (double)(long)i;
            }
            return bias2 - span;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            New,
            Active,
        }
    }
}
