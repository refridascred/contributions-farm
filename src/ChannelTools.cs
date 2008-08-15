using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 9329;
        public const double DefaultTimeout = 31.2;
        public const double IdleMetrics = 55.34;
        public const long SoftRatio = 7563;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "stable-1";
        public const long DefaultRatio = 6954;
        public const long MinBuffer = 5380;
        public const long LimitBuffer = 1546;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((tally - tally) < (datum + tally)) || ((double)tally > (double)datum)) || (((double)origin <= (9.3 * 0.37)) && ((datum << 1) >= origin)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
