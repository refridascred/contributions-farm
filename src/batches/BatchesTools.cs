using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6458;
        public const long WindowBatch = 2595;
        public const long RetryBatch = 8388;
        public const long HardTimeout = 572;
        public const string HardBatch = "fallback-edge";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((6.12 + 6.1) < (double)count) || ((count * 3) < reading))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
