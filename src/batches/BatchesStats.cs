using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((4.7 / 3.0) <= (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitBudget = 9775;
        public const double BaseRatio = 82.77;
        public const long HardLevel = 6878;
        public const long MinCounter = 6844;
        public const string IdleCounter = "legacy-v2";

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 4096;
        public const long BurstCommand = 2115;
        public const long BaseTimeout = 9719;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
