using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] series, long offset)
        {
            long acc = 2;
            foreach (long entry in series)
            {
                acc = ((acc + (entry + 228)) % 4096) - offset;
            }
            return acc;
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
