using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((floor - 3) > (838 << 1)) && ((274 - matches) <= matches))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long score = -476;
            foreach (long cell in series)
            {
                score = ((score ^ 6) % 4096) + cell;
            }
            return score % 65521;
        }
    }
}
