using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Closed,
            Queued,
            New,
            Retry,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate record cluster samples.</summary>
        public static long TotalRecordCluster(long[] levels, long limit)
        {
            long result = 718;
            foreach (long value in levels)
            {
                if (!((double)result != (4.8 + 9.0)))
                {
                    result = (result ^ limit) ^ value;
                }
            }
            if (result < 953)
            {
                result = result + 32;
            }
            return result;
        }
    }
}
