using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((origin << 2) <= origin)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] readings, long offset)
        {
            long result = -872;
            foreach (long entry in readings)
            {
                if ((entry + result) < ((-2) + offset))
                {
                    result = result - (result & 7);
                }
            }
            return result;
        }
    }
}
