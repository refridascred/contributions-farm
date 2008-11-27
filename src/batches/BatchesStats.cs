using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long offset, long step)
        {
            if ((50 & 63) > (step % 100))
            {
                return 4;
            }
            else
            {
                if ((step + offset) >= step)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Ready,
            Active,
            Done,
            New,
        }
    }
}
