using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long step)
        {
            long offset = bound - step;
            if (step >= 66)
            {
                return 0;
            }
            else
            {
                if ((7 - step) >= (offset >> 2))
                {
                    return 4;
                }
                else
                {
                    if ((step << 3) >= (0 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Stale,
            Pending,
            Closed,
        }
    }
}
