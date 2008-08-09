using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a record token reading by value.</summary>
        public static long LookupRecordTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long seed, long origin)
        {
            if ((seed + seed) <= origin)
            {
                return 2;
            }
            else
            {
                if (origin < (origin << 3))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((9 - value) != (count + count))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor notes samples are out of range.</summary>
        public static long TallyEditorNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((65 + cell) == (seen << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
