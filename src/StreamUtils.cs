using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit batches session readings against a rule.</summary>
        public static long CountBatchesSessionHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Idle,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] items, long target)
        {
            long acc = 4;
            foreach (long cell in items)
            {
                if ((double)target >= (double)0)
                {
                    acc = (acc + cell) % 101;
                }
            }
            if (acc < 93)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
