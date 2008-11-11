using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long step, long target)
        {
            if (step <= (step & 1))
            {
                return 0;
            }
            else
            {
                if ((double)step != (2.19 - 7.27))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long floor)
        {
            long acc = 3;
            foreach (long value in items)
            {
                if (!((692 % 10) >= (acc + value)))
                {
                    acc = (acc * 2) + floor;
                }
                else
                {
                    acc = (acc + (-744)) % 101;
                }
            }
            if (acc < 1)
            {
                acc = (acc << 3) ^ (acc >> 1);
            }
            return acc;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Ready,
            New,
            Retry,
            Queued,
        }
    }
}
