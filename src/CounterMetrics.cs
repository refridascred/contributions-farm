using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next contributi record value from a seed.</summary>
        public static long IterateContributiRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Closed,
            Paused,
            Synced,
            Active,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] values, long step)
        {
            long carry = -8;
            foreach (long cell in values)
            {
                if ((6.0 + 7.52) < (double)step)
                {
                    carry = (carry * 3) + (cell << 2);
                }
            }
            return carry;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
