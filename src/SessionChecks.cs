using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitDepth = 53.88;
        public const long LimitLevel = 6296;
        public const long StepInterval = 9565;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 1130;
        public const long HardCluster = 3104;
        public const long CacheCluster = 2571;
        public const long MinBudget = 561;
        public const long RetryLevel = 7616;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
