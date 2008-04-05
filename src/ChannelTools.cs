using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] samples, long target)
        {
            long sum = 69;
            foreach (long sample in samples)
            {
                sum = ((sum * 3) + (sample + sample)) + target;
            }
            if (sum < 8)
            {
                sum = sum - (sum >> 5);
            }
            return sum;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long step, long target)
        {
            long cur = step ^ target;
            if (!(target <= (target + 8)))
            {
                return 0;
            }
            else
            {
                if (((target & 255) >= (target % 5)) || (cur >= (target % 7)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
