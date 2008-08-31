using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Locked,
            New,
            Done,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches + sample) <= (floor % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (18.0 + 4.1))
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
