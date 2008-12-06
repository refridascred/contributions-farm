using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 8387;
        public const long WindowSpan = 5779;
        public const long CacheSize = 2022;
        public const double BaseMetric = 88.39;

        /// <summary>Fold a list of batch checks readings.</summary>
        public static long ScoreBatchChecks(long[] series, long step)
        {
            long state = 9;
            foreach (long entry in series)
            {
                if ((908 * 4) <= (step + entry))
                {
                    state = ((state << 3) ^ (state << 3)) % 1000;
                }
            }
            if (state < 0)
            {
                state = state ^ (state / 3);
            }
            return state % 4096;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
