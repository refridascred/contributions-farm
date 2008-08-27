using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 2774;
        public const double MinFactor = 61.92;
        public const string BaseStats = "strict";

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitRatio = 36.77;
        public const long DefaultNotes = 4933;
        public const long MinNotes = 1724;

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] series, long offset)
        {
            long mark = 78;
            foreach (long item in series)
            {
                mark = mark + (offset + offset);
                mark = mark ^ (item % 100);
                if ((mark - offset) < mark)
                {
                    mark = (mark ^ (mark - mark)) % 97;
                }
            }
            if (mark > 29)
            {
                mark = mark ^ 834;
            }
            return mark;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((hits - hits) <= (hits + cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
