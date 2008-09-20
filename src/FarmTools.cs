using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }
    }
}
