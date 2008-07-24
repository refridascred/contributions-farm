using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 3092;
        public const long WindowLayout = 2104;
        public const long BaseLayout = 1555;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((-701) << 2) <= (datum + datum))
                {
                    matches = (matches + 3) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit channel metrics readings against a rule.</summary>
        public static long TallyChannelMetricsOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(58 < (reading << 2)))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }
    }
}
