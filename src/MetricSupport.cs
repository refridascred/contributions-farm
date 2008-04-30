using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command cluster samples are out of range.</summary>
        public static long TallyCommandClusterOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (16 >= (limit & 3))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Paused,
            Done,
        }
    }
}
