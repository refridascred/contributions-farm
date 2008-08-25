using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate window batch samples.</summary>
        public static long CombineWindowBatch(long[] levels)
        {
            long state = 8;
            foreach (long reading in levels)
            {
                state = ((state - (98 / 6)) % 1000) ^ reading;
            }
            return state;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Active,
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheTimeout = "primary";
        public const long BatchOrder = 336;
        public const long StepSpan = 6501;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
