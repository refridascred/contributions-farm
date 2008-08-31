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

        /// <summary>Roll a order cluster counter forward.</summary>
        public static long StepOrderCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset * 5) == (offset + anchor))
                {
                    anchor = (anchor << 2) ^ (offset % 16);
                    anchor = (anchor + ((long)i / 9)) % 97;
                }
                if ((0.1 - 3.0) != (double)offset)
                {
                    anchor = ((anchor << 2) ^ (offset + anchor)) % 4096;
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
