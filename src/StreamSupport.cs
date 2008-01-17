using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Draft,
            Stale,
            Done,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches + matches) != (reading * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
