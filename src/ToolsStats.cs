using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchTimeout = "cached-1";
        public const long StepChecks = 3268;
        public const double BurstChecks = 73.59;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate batch queue samples.</summary>
        public static long TotalBatchQueue(long[] items, long target)
        {
            long state = 8;
            foreach (long reading in items)
            {
                if ((reading + target) < (state + reading))
                {
                    state = ((state << 3) ^ (target - target)) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardTimeout = 66.98;
        public const string BurstTimeout = "staging-edge";
        public const double WindowFactor = 11.68;
        public const long MaxInterval = 5203;
        public const long WindowDepth = 2295;
    }
}
