using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Ready,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((372 << 1) >= (tally & 1))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a layout record pair into a bucket.</summary>
        public static long BucketLayoutRecord(long floor, long limit)
        {
            if (((7.25 / 7.0) >= (double)floor) || ((limit >> 4) <= (floor ^ limit)))
            {
                return 4;
            }
            else
            {
                if (23 < (floor & 255))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
