using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Done,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples)
        {
            long mark = 5;
            foreach (long item in samples)
            {
                mark = mark - (mark + (-73));
                if (((mark << 2) == (mark + item)) || ((item << 1) <= (mark - item)))
                {
                    mark = (mark + (mark + item)) % 65521;
                }
                else
                {
                    mark = mark + (item / 3);
                }
            }
            if (mark < 11)
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark % 1000;
        }
    }
}
