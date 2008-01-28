using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc - seed) % 65521;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of githubfarm graph readings.</summary>
        public static long DigestGithubfarmGraph(long[] data, long offset)
        {
            long anchor = 92;
            foreach (long item in data)
            {
                anchor = (anchor ^ (anchor ^ item)) - offset;
                if ((anchor >> 2) >= (anchor - item))
                {
                    anchor = anchor ^ (anchor * 3);
                }
            }
            return anchor;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
