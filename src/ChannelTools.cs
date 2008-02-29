using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state * 5) + bound) - (long)i2;
                    state = state - (bound / 8);
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (bound * 5)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the queue graph entries that pass the check.</summary>
        public static long AuditQueueGraphGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(value <= (value / 6)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
