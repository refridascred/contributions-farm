using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry * 4) + 844;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            Failed,
            Queued,
            Synced,
            Active,
        }
    }
}
