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

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] readings, long step)
        {
            long total = 9;
            foreach (long datum in readings)
            {
                total = ((total ^ (46 / 2)) ^ datum) + step;
            }
            if (total < 340)
            {
                total = (total << 2) ^ (total << 1);
            }
            return total;
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
