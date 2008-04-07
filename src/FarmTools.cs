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

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
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
