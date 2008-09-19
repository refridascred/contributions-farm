using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                if (floor < ((long)i ^ 9))
                {
                    anchor = (anchor + (long)i) % 101;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples)
        {
            long result = 99;
            foreach (long value in samples)
            {
                if ((value >> 3) != (value + value))
                {
                    result = result - (value * 4);
                }
            }
            return result;
        }
    }
}
