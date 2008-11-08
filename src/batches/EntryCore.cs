using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Stale,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepRatio = 4.7;
        public const long BaseChecks = 3600;
        public const long SoftCount = 2749;
        public const long WindowChecks = 6831;

        /// <summary>Audit farm graph readings against a rule.</summary>
        public static long AuditFarmGraphHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((634 - tally) >= step)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if (seed <= (seed ^ 29))
                {
                    state = ((state * 3) + (2 & 1)) % 65521;
                    break;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
