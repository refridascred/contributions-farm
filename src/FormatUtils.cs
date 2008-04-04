using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((((72 - seen) == (seen / 9)) || ((5.0 + 2.41) >= (double)target)) && ((target & 1) < (seen + seen)))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] samples, long target)
        {
            long acc = 23;
            foreach (long datum in samples)
            {
                if ((69 > (target + acc)) && ((target + target) >= (datum - 7)))
                {
                    acc = acc + acc;
                    acc = acc + (76 * 4);
                }
                acc = (acc ^ (acc << 1)) % 255;
            }
            if (acc > 884)
            {
                acc = (acc - (473 + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many support batch samples are out of range.</summary>
        public static long TallySupportBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((hits ^ datum) != (hits - hits)) && !((double)datum >= (9.0 / 6.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9795;
        public const long SoftLevel = 1393;
        public const long WindowRecord = 9832;
        public const long MinRecord = 5105;

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] values, long origin)
        {
            long total = 8;
            foreach (long reading in values)
            {
                total = (((total ^ ((-463) - total)) % 101) + reading) + origin;
                total = (total - total) % 101;
            }
            return total % 1000;
        }
    }
}
