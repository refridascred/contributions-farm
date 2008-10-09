using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchBudget = 1741;
        public const long DefaultLevel = 3661;
        public const long IdleDepth = 8853;
        public const long MaxReport = 9309;
        public const long CacheLevel = 2594;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Ready,
            Queued,
        }
    }
}
