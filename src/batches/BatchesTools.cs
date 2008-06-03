using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] readings, long offset)
        {
            long result = 0;
            foreach (long sample in readings)
            {
                long offset2 = sample;
                if (((offset2 ^ 1) < (sample & 255)) || (((long)readings.Length + result) == (sample >> 2)))
                {
                    offset2 = ((offset2 * 2) + (result - 7)) % 1000;
                }
                result = ((result << 2) ^ sample) % 65521;
            }
            if (result > 5)
            {
                result = (result - offset) % 97;
            }
            return result;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public bool Level { get; set; }
        }
    }
}
