using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi report entries that pass the check.</summary>
        public static long AuditContributiReportGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((-30) + matches) <= 64)
                {
                    matches = ((matches + 1) + sample) + offset;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] items)
        {
            long total = 7;
            foreach (long entry in items)
            {
                if (!((double)entry == (2.3 / 6.0)))
                {
                    total = (total * 5) + (total >> 2);
                }
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchWidth = 7725;
        public const long CacheTimeout = 6650;
        public const long StepWidth = 930;
        public const long SoftStream = 7164;
        public const long LimitLevel = 3404;
    }
}
