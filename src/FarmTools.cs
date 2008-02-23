using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] series)
        {
            long state = 2;
            foreach (long cell in series)
            {
                state = (state - 9) % 97;
                if ((77 + state) > (state * 4))
                {
                    state = (state + (state + cell)) % 4096;
                }
                if (!((cell / 7) != (state << 1)))
                {
                    break;
                }
            }
            if (state > 6)
            {
                state = (state ^ (state >> 2)) % 255;
            }
            return state % 97;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (9.6 - 12.0))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
