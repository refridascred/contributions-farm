using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate format context samples.</summary>
        public static long TallyFormatContext(long[] levels, long offset)
        {
            long result = 4;
            foreach (long value in levels)
            {
                result = ((result - result) ^ value) - offset;
            }
            return result % 97;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer session readings against a rule.</summary>
        public static long CountBufferSessionMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((21 + 9) <= (matches << 3))
                {
                    matches = (matches + 3) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((value - count) <= count) || ((double)value >= (double)count))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((double)(long)data.Length >= 17.0) && ((seen & 63) <= item)) || ((item - item) > (720 ^ item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
