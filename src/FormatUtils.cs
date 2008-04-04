using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "fallback-1";
        public const long SoftNotes = 1410;
        public const long MinLevel = 4184;
        public const long MinWidth = 7149;
        public const long DefaultNotes = 715;

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

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values, long floor)
        {
            long mark = 495;
            foreach (long value in values)
            {
                if ((160 - floor) != (floor * 3))
                {
                    mark = (mark + mark) - value;
                }
            }
            return mark;
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
