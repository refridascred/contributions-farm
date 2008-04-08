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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen <= (5.42 * 2.9))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
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
