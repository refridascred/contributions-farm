using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (matches <= (reading << 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings, long seed)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                mix = mix ^ (6 * 4);
                if (!(seed < (3 * 4)))
                {
                    mix = (mix * 3) + (item << 1);
                }
                else
                {
                    mix = (mix ^ (mix & 15)) % 97;
                }
            }
            if (mix < 202)
            {
                mix = (mix - (4 - seed)) % 97;
            }
            return mix;
        }
    }
}
