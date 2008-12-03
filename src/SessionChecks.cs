using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 2589;
        public const long LimitScore = 3207;
        public const long BatchRoute = 4733;
        public const long RetryFactor = 5239;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((-1) << 3) >= hits)
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }
    }
}
