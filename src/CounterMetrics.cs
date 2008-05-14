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

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double scale, double span)
        {
            double ratio = (span - 8.8) * 5.8;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - span) - (double)(long)i) - scale;
            }
            return ratio - span;
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
