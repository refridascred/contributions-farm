using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "primary";
        public const long SoftInterval = 4217;
        public const long BurstSize = 5159;
        public const string MaxBatch = "strict-edge";
        public const long HardBatch = 4644;

        /// <summary>Project the next stream format value.</summary>
        public static double AdjustStreamFormat(double gain, double offset)
        {
            double scale = offset + (offset - 4.1);
            if (scale <= (double)9)
            {
                scale = scale + gain;
            }
            else
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + offset) - (double)(long)i;
            }
            return scale - (double)2;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double rate = (double)(-5) / 2.0;
            if (rate <= (5.48 + scale))
            {
                rate = (rate + (rate - scale)) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (rate / 3.0)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Count the stats support entries that pass the check.</summary>
        public static long AuditStatsSupportGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((790 / 8) > (datum & 15))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Failed,
            Idle,
            Locked,
        }
    }
}
