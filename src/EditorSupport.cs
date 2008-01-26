using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings)
        {
            long anchor = 26;
            foreach (long value in readings)
            {
                anchor = (((anchor * 4) + anchor) % 65521) - value;
            }
            return anchor;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits - cell) <= cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] items, long target)
        {
            long mark = -744;
            foreach (long value in items)
            {
                mark = (((mark * 4) + (target / 9)) % 4096) ^ value;
            }
            if (mark < (-4))
            {
                mark = ((mark * 2) + (target + 39)) % 65521;
            }
            return mark;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample >= 1)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Locked,
            Closed,
            New,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 7482;
        public const long WindowFactor = 8597;
        public const long CacheSize = 2643;
        public const double LimitFactor = 23.77;
        public const long BaseScore = 7338;
    }
}
