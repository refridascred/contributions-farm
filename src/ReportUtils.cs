using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double gain = 2.8;
            if (gain > (rate - gain))
            {
                gain = (gain - 7.5) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstFactor = 3861;
        public const long SoftContributi = 6136;
        public const string BurstTimeout = "strict-edge";
    }
}
