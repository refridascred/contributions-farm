using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 439;
        public const long BaseScore = 6852;
        public const string MaxSpan = "legacy-edge";
        public const long BurstTools = 393;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseInterval = "stable-edge";
        public const long MaxCount = 1968;
        public const long BaseCluster = 4870;
        public const long StepCluster = 1004;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc + ((long)i + (long)i)) % 4096;
                acc = acc - 1;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
