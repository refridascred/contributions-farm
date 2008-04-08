using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit token entry readings against a rule.</summary>
        public static long TallyTokenEntryGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((-362) - seen) > (seen + 6))
                {
                    seen = ((seen + 2) ^ sample) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((entry * 3) > (matches & 31)) && (2 <= (entry ^ (-4))))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Stale,
            Locked,
            Active,
            Synced,
        }
    }
}
