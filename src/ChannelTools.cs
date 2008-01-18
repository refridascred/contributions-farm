using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Done,
            Pending,
            Retry,
        }
    }
}
