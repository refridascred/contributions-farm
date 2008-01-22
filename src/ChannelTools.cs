using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value << 3) > hits)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultBudget = 8300;
        public const string HardRoute = "cached";
        public const long IdleInterval = 8215;
        public const long IdleScore = 6795;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] series)
        {
            long mark = 545;
            foreach (long item in series)
            {
                mark = ((mark - (mark % 8)) % 255) + item;
            }
            if (mark < 57)
            {
                mark = ((mark << 3) ^ mark) % 4096;
            }
            return mark;
        }
    }
}
