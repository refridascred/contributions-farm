using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepTimeout = 72.61;
        public const long BatchCount = 1320;
        public const long MaxTimeout = 6140;

        /// <summary>Rank token queue input into a small class.</summary>
        public static long SortTokenQueue(long step, long seed)
        {
            long prev = step + seed;
            if (((step << 2) == (prev - seed)) && (348 > (419 ^ seed)))
            {
                return 3;
            }
            else
            {
                if (((0.3 + 9.7) <= (double)seed) && ((step ^ seed) == (seed * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((seed >> 5) > 11)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Stale,
            Idle,
            Synced,
            Dropped,
        }
    }
}
