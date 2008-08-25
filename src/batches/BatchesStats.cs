using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = score + (958 % 10);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Active,
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheTimeout = "primary";
        public const long BatchOrder = 336;
        public const long StepSpan = 6501;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
