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

        /// <summary>Audit layout notes readings against a rule.</summary>
        public static long AuditLayoutNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + hits) < (value - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
