using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 77.19;
        public const double WindowEditor = 26.93;
        public const long DefaultFactor = 2616;
        public const long RetryEditor = 3244;
        public const long CacheEditor = 3368;

        /// <summary>Roll a cache account counter forward.</summary>
        public static long StepCacheAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i <= (seed + (long)i))
                {
                    state = ((state << 3) ^ (seed & 127)) % 101;
                    break;
                }
                else
                {
                    state = (state ^ (seed - (long)i)) % 65521;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length - cell) < (tally / 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item & 3) >= (item & 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Failed,
            Locked,
            Idle,
            Done,
            Synced,
        }
    }
}
