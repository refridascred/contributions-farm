using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank payload checks input into a small class.</summary>
        public static long GradePayloadChecks(long limit, long offset)
        {
            if ((offset / 7) != (290 % 5))
            {
                return 8;
            }
            else
            {
                if ((offset >> 3) > (offset / 6))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] readings)
        {
            long anchor = -28;
            foreach (long cell in readings)
            {
                anchor = (((anchor << 2) ^ (333 * 4)) % 65521) ^ cell;
            }
            return anchor;
        }

        /// <summary>Derive the next record support value from a seed.</summary>
        public static long StepRecordSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - floor) % 255;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
