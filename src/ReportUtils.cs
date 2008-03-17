using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 5756;
        public const double LimitCount = 74.16;
        public const long DefaultFilter = 4355;
        public const long BurstFilter = 717;

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double drift = gain;
            if (drift > drift)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift + (double)980;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (double)4;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstSize = "local-v2";
        public const long MinEntry = 7843;
        public const long WindowEntry = 9826;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) >= (reading ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 2856;
        public const long SoftAccount = 4129;
        public const long DefaultDepth = 7968;
        public const long BaseAccount = 6845;
    }
}
