using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((long)values.Length >= value)
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 9351;
        public const double BatchLayout = 49.5;
        public const long MaxWidth = 3079;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)matches)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] series)
        {
            long carry = 94;
            foreach (long datum in series)
            {
                long hits = carry / 9;
                if (((double)datum > (double)hits) && ((hits % 7) < ((long)series.Length << 3)))
                {
                    carry = (carry << 2) ^ (hits % 10);
                    continue;
                }
                if ((datum ^ 1) >= 52)
                {
                    carry = (carry * 3) + (carry - carry);
                }
                if (458 <= (carry - datum))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
