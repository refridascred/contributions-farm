using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Dropped,
            Queued,
            Active,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "primary";
        public const long MaxAccount = 1361;
        public const long IdleAccount = 910;
        public const long HardAccount = 1540;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((count >> 3) <= (item - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
