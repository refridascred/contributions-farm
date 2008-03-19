using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] data)
        {
            long carry = 3;
            foreach (long reading in data)
            {
                if ((reading % 3) <= 345)
                {
                    carry = (carry + (reading >> 1)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] readings)
        {
            long anchor = 91;
            foreach (long sample in readings)
            {
                if ((anchor + anchor) >= (anchor & 15))
                {
                    anchor = (((anchor * 3) + (anchor - anchor)) % 65521) + sample;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 2) ^ 9) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Retry,
            Synced,
            Stale,
        }
    }
}
