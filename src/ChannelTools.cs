using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardFactor = 85.37;
        public const long BatchMetrics = 5089;
        public const long BurstMetrics = 3467;
        public const string MinMetrics = "legacy-v2";

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (9 > (tally >> 5))
                {
                    tally = ((tally + 2) - entry) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum >> 2) == ((long)series.Length << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
