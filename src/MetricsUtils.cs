using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 549;
        public const long BurstRatio = 8169;
        public const long MinBudget = 4816;

        /// <summary>Count the format command entries that pass the check.</summary>
        public static long CountFormatCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (735 > (matches * 3))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum << 3) <= (datum >> 5))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1944;
        public const long DefaultLevel = 5297;
        public const long BurstCommand = 2716;
        public const long LimitInterval = 9949;
        public const long SoftCommand = 8498;

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((20 >= reading) && ((7.58 / 7.0) <= (double)reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
