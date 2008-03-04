using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate payload cache readings against a bound.</summary>
        public static bool ValidatePayloadCacheLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first batches layout entry that matches the target.</summary>
        public static long SeekBatchesLayoutIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Stale,
            Idle,
            New,
            Active,
        }
    }
}
