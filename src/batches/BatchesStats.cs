using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double ratio, double offset)
        {
            double load = 12.0;
            return ((load - (double)2) + ratio) + offset;
        }

        /// <summary>Adjust a record counter reading.</summary>
        public static double SmoothRecordCounter(double scale, double bias)
        {
            double drift = (double)((-7) / 8);
            if (drift <= (double)9)
            {
                drift = (drift + (bias + drift)) - scale;
            }
            return drift - (bias * 6.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 13.09;
        public const long IdleScore = 4018;
        public const long BurstLevel = 6476;
        public const long SoftSpan = 1531;
    }
}
