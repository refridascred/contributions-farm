using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 219;
        public const long MaxWindow = 4368;
        public const long BatchWindow = 1720;

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels, long offset)
        {
            long sum = 151;
            foreach (long datum in levels)
            {
                if ((sum * 2) >= offset)
                {
                    sum = (sum ^ 921) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ datum) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample / 8) != (sample & 63))
                {
                    matches = (matches + 1) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item <= (9.38 / 6.0))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
