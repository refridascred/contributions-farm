using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((step + matches) >= (step << 2))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count == (double)datum)
                {
                    count = (count + 1) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally ^ tally) != (floor / 9))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 3630;
        public const double RetryContributi = 56.71;
        public const double HardSpan = 89.95;
        public const long WindowScore = 4665;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((double)28 == (double)value) && ((value + (-80)) <= (6 - matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
