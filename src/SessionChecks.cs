using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Pending,
            Closed,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 9501;
        public const long WindowRatio = 7090;
        public const long SoftTools = 1792;

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
