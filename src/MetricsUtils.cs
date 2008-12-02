using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the counter notes entries that pass the check.</summary>
        public static long TallyCounterNotesHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry - 6) <= ((long)series.Length >> 1))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 35.2;
        public const long RetryProfile = 1819;
        public const long MinProfile = 4628;

        /// <summary>Define record limits and defaults.</summary>
        public const double RetrySpan = 48.1;
        public const long MinSpan = 8574;
        public const long IdleBudget = 4504;
        public const long BaseRecord = 1877;
        public const long MaxRecord = 3751;

        /// <summary>Measure how many support stream samples are out of range.</summary>
        public static long MeasureSupportStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((52 - 14) < (reading - 9)) || ((reading ^ seen) == (seen - seen)))
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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item + item) <= (1 - item)))
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
