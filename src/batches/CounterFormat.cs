using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long target, long step)
        {
            if ((0 > (target + 5)) || ((double)target > (8.8 / 7.0)))
            {
                return 6;
            }
            else
            {
                if ((target << 2) <= (step * 2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Closed,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Active,
            Done,
            Closed,
            Locked,
        }
    }
}
