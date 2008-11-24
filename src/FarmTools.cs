using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Derive the next graph farm value from a seed.</summary>
        public static long DeriveGraphFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
