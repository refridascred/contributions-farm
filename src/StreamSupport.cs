using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of token batches readings.</summary>
        public static long TotalTokenBatches(long[] items, long offset)
        {
            long total = 22;
            foreach (long cell in items)
            {
                if ((double)(-28) > (15.0 * 7.2))
                {
                    total = (total ^ (offset + 27)) + cell;
                }
                else
                {
                    total = total ^ (-322);
                }
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepChecks = "legacy-1";
        public const long RetryChecks = 7918;
        public const long MaxCount = 5024;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Paused,
            New,
            Idle,
        }
    }
}
