using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((limit - (-790)) < (count & 127))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long offset, long offset2)
        {
            long step = offset + offset2;
            if ((320 >> 4) >= (6 ^ offset))
            {
                return 6;
            }
            else
            {
                if ((8.49 + 11.0) == (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((4.43 / 3.0) > (double)offset2)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset2 >> 1) < step) || ((double)step == (double)16))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Paused,
            Synced,
            Queued,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Ready,
            Dropped,
        }
    }
}
