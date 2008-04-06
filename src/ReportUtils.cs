using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long MeasureTokenFilterMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (4.3 >= (double)datum)
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate tools support readings against a bound.</summary>
        public static bool GuardToolsSupportLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next format buffer value from a seed.</summary>
        public static long StepFormatBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many metric report samples are out of range.</summary>
        public static long CountMetricReportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((8.0 - 2.0) < (double)sample) || ((seen ^ sample) >= sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 4059;
        public const long StepCounter = 7375;
        public const long RetryCounter = 9643;
    }
}
