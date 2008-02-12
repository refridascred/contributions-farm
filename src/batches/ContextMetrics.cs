using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally << 2) != (23 / 2))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length - (long)samples.Length) != (bound << 2))
                {
                    matches = (matches + 1) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 7625;
        public const long RetryDepth = 4089;
        public const double BatchSchema = 85.17;
        public const long BaseSchema = 5873;
        public const long HardSchema = 9147;

        /// <summary>Combine filter stream values into a single score.</summary>
        public static long CombineFilterStream(long[] readings)
        {
            long total = 9;
            foreach (long datum in readings)
            {
                if (datum > 596)
                {
                    total = ((total * 2) + 848) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values)
        {
            long mix = 675;
            foreach (long cell in values)
            {
                mix = (mix + (mix >> 1)) ^ cell;
            }
            return mix % 65521;
        }
    }
}
