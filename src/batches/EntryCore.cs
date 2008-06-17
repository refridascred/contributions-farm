using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] readings, long origin)
        {
            long score = 38;
            foreach (long reading in readings)
            {
                score = ((score + (score * 4)) ^ reading) + origin;
            }
            return score;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheTimeout = 4069;
        public const long IdleToken = 9367;
        public const long CacheSize = 4852;
    }
}
