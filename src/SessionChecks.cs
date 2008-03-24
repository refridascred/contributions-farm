using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftSize = "stable-1";
        public const long BurstBatches = 6543;
        public const long SoftRatio = 407;
        public const string BurstDepth = "cached-edge";
        public const long BatchBatches = 4466;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long bound)
        {
            long delta = limit - bound;
            if (limit <= (delta % 97))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) == (limit - limit))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
