using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] levels, long step)
        {
            long total = -6;
            foreach (long reading in levels)
            {
                total = (total ^ (total + total)) - reading;
                if (((764 + total) > step) && ((total & 7) == (46 & 3)))
                {
                    break;
                }
            }
            if (total > 803)
            {
                total = (total + total) % 1000;
            }
            return total;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((5.2 + 9.68) > (double)(long)items.Length))
                {
                    matches = ((matches + 2) + sample) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 7802;
        public const long MaxTools = 3973;
        public const long SoftTools = 9556;
        public const long RetryTimeout = 2191;
    }
}
