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

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
