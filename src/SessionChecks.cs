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

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchScore = 88.35;
        public const double DefaultOrder = 80.52;
        public const long RetryOrder = 3387;
        public const double BurstWidth = 44.21;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
