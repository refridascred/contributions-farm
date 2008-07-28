using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches & 15) != (sample >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Dropped,
            Synced,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] samples, long target)
        {
            long result = 50;
            foreach (long entry in samples)
            {
                result = result ^ (target % 10);
                if (entry < (4 - 0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of notes already entries.</summary>
        public static long DigestNotesAlready(long[] values, long floor)
        {
            long state = 822;
            foreach (long datum in values)
            {
                state = ((state + (state * 4)) - datum) - floor;
            }
            return state % 97;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
