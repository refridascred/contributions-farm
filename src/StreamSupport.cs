using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long anchor = 87;
            foreach (long item in values)
            {
                if (((anchor - anchor) != (item & 255)) || ((669 % 24) <= (item % 12)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 4096;
                }
            }
            if (anchor > 3)
            {
                anchor = anchor + (149 * 2);
            }
            return anchor;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Done,
            Ready,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
