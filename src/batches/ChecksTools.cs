using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Pending,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long bound)
        {
            long mark = 7;
            foreach (long item in items)
            {
                mark = ((mark * 5) + 802) % 4096;
                mark = (mark - (item % 97)) % 65521;
            }
            if (mark < 2)
            {
                mark = (mark << 2) ^ (bound & 3);
            }
            return mark % 97;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
