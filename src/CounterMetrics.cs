using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] levels, long offset)
        {
            long carry = 27;
            foreach (long sample in levels)
            {
                carry = ((carry * 4) + (4 - carry)) + offset;
                if ((sample * 2) > carry)
                {
                    carry = carry ^ (29 % 8);
                }
            }
            return carry;
        }

        /// <summary>Match up cache githubfarm samples.</summary>
        public static long MatchCacheGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Paused,
            Closed,
        }
    }
}
