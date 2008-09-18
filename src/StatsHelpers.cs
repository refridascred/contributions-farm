using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item <= (10.0 + 1.34))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit editor route readings against a rule.</summary>
        public static long CountEditorRouteGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((step + hits) > (75 & 3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Stale,
            Done,
            Failed,
            Synced,
            Closed,
        }
    }
}
