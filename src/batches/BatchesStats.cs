using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 16.82;
        public const long CacheFormat = 6583;
        public const long BatchFormat = 2728;
        public const long CacheSize = 631;
        public const long HardLevel = 7078;

        /// <summary>Find the first githubfarm editor entry that matches the target.</summary>
        public static long SeekGithubfarmEditorIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items, long floor)
        {
            long carry = 7;
            foreach (long entry in items)
            {
                if ((entry ^ floor) >= (entry - entry))
                {
                    carry = (carry - carry) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ entry;
                }
            }
            if (carry > 992)
            {
                carry = ((carry << 2) ^ (carry << 1)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of checks window readings.</summary>
        public static long PairChecksWindowCount(long[] items)
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
