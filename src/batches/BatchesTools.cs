using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a queue route sample.</summary>
        public static long LocateQueueRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window graph entries that pass the check.</summary>
        public static long MeasureWindowGraphGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((70 + value) == (count + (long)readings.Length)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Stale,
            Draft,
        }
    }
}
