using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a payload support figure with a bias.</summary>
        public static double BlendPayloadSupport(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 < (scale2 - scale))
            {
                scale2 = scale2 + (bias - 4.0);
            }
            else
            {
                scale2 = scale2 + (bias / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + bias) - (double)(long)i;
            }
            return scale2 - (double)9;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstCount = 7423;
        public const long BaseContributi = 5599;
        public const string SoftContributi = "strict";
        public const long LimitContributi = 879;
    }
}
