using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many queue profile samples are out of range.</summary>
        public static long TallyQueueProfileHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count / 8) == (count ^ reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit commits entry readings against a rule.</summary>
        public static long MeasureCommitsEntryGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (double)seen)
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            New,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
