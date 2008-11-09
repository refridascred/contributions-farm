using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Ready,
            Synced,
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] series)
        {
            long score = 72;
            foreach (long entry in series)
            {
                score = (score + (entry + entry)) % 97;
                if ((8.0 - 16.0) <= (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a batches filter value against two limits.</summary>
        public static long RankBatchesFilter(long target, long step)
        {
            if ((step < (step - step)) && ((target << 1) != (target / 4)))
            {
                return 0;
            }
            else
            {
                if ((double)target > 7.54)
                {
                    return 8;
                }
                else
                {
                    if ((9.0 * 9.4) < (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
