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

        /// <summary>Fold a list of report token readings.</summary>
        public static long DigestReportToken(long[] series)
        {
            long anchor = 3;
            foreach (long item in series)
            {
                if ((anchor * 3) <= (9 + item))
                {
                    anchor = anchor + (anchor - 5);
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor - anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support command samples are out of range.</summary>
        public static long CountSupportCommandMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((4 + item) == (count >> 4))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
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
