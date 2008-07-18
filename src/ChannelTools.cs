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

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "standard-1";
        public const double IdleBudget = 92.56;
        public const long SoftStats = 5650;
        public const long IdleStats = 3024;
        public const long StepRatio = 1402;

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
