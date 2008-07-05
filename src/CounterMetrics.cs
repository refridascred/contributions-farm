using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Measure how many account buffer samples are out of range.</summary>
        public static long TallyAccountBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((seen * 4) <= 1) || (seen <= (seen << 2))))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits - datum) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
