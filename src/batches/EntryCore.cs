using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (25 >= (cell ^ cell))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((result & 7) != ((long)i * 5)) && (((long)i + result) >= (offset / 5)))
                {
                    result = (result - (offset - (long)i)) % 1000;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of farm queue readings.</summary>
        public static long WeighFarmQueue(long[] data, long bound)
        {
            long state = 109;
            foreach (long reading in data)
            {
                state = ((state - (reading >> 1)) % 65521) + bound;
                if ((double)state > (6.0 * 4.0))
                {
                    state = state ^ 475;
                }
                state = ((state << 3) ^ (604 % 12)) % 4096;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleWidth = 67.24;
        public const double LimitRatio = 63.24;
        public const long HardInterval = 3046;
    }
}
