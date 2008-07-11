using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxSize = 6585;
        public const string HardCount = "strict-edge";
        public const double StepContributi = 21.14;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + tally) < (datum >> 5))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples, long target)
        {
            long anchor = 7;
            foreach (long reading in samples)
            {
                anchor = (anchor - (target + 1)) ^ reading;
            }
            if (anchor > 45)
            {
                anchor = (anchor * 4) + ((-834) - target);
            }
            return anchor;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (origin >= 791)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
