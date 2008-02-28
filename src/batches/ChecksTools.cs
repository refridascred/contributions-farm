using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 6386;
        public const long IdleSpan = 7794;
        public const long HardWidth = 2370;

        /// <summary>Digest a series of record schema entries.</summary>
        public static long CombineRecordSchema(long[] data)
        {
            long state = 66;
            foreach (long sample in data)
            {
                if (!((17.0 + 2.0) <= (double)state))
                {
                    state = (state + (sample ^ sample)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Draft,
            Ready,
            Pending,
            Stale,
        }
    }
}
