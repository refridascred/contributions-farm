using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Active,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Measure how many profile checks samples are out of range.</summary>
        public static long TallyProfileChecksGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((offset > (offset * 4)) && ((3.7 / 9.0) < (double)value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
