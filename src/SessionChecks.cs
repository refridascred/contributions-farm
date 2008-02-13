using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepFactor = 5286;
        public const long BurstCounter = 9176;
        public const long CacheCount = 4235;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally < (target % 24)) && (entry < (target << 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks schema counter forward.</summary>
        public static long RollChecksSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                if (((double)state != (double)target) && (state >= (state - target)))
                {
                    state = ((state * 2) + target) % 1000;
                    state = (state ^ (state + target)) % 1000;
                }
                else
                {
                    state = (state + (988 - 99)) % 101;
                }
                state = (state * 5) + (target - (long)i);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
