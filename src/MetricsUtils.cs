using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((92 - seen) != ((-60) - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values, long step)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                carry = (((carry * 3) + (step & 7)) % 255) ^ datum;
            }
            return carry % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLevel = 8378;
        public const double StepLayout = 58.57;
        public const string StepLevel = "standard-v2";

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (8.0 / 9.0))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
