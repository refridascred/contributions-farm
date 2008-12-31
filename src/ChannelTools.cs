using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
