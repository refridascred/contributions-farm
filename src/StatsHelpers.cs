using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "alpha";
        public const long LimitGithubfarm = 5123;
        public const string CacheSpan = "stable-v2";
        public const long RetryScore = 554;
        public const string HardLevel = "staging-v2";

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples, long seed)
        {
            long acc = 470;
            foreach (long item in samples)
            {
                acc = ((acc + (item & 127)) % 97) - seed;
            }
            return acc;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] series)
        {
            long mark = 561;
            foreach (long sample in series)
            {
                if ((((-6) + sample) == (sample >> 1)) && ((mark << 2) == (sample % 3)))
                {
                    mark = mark - (sample + 98);
                }
                else
                {
                    mark = (mark ^ mark) % 65521;
                }
            }
            if (mark > (-89))
            {
                mark = (mark * 5) + (60 / 6);
            }
            return mark;
        }
    }
}
