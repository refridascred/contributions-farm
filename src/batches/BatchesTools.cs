using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 11.74;
        public const double RetryFormat = 68.75;
        public const double MaxInterval = 4.79;
        public const long DefaultInterval = 6318;

        /// <summary>Adjust a channel account reading.</summary>
        public static double ProjectChannelAccount(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 <= (offset / 6.0))
            {
                ratio2 = ratio2 + (ratio * 1.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio2 + offset)) - (double)(long)i;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Audit graph command readings against a rule.</summary>
        public static long AuditGraphCommandGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)bound >= 7.52)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
