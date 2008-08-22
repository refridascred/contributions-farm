using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleDepth = 2835;
        public const long MinEntry = 2119;
        public const string RetryEntry = "primary-edge";
        public const double HardDepth = 11.3;
        public const long WindowCount = 5154;

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "latest";
        public const string RetryEditor = "standard-1";
        public const long MinEditor = 6647;
        public const long BatchLevel = 2437;
        public const string BatchFactor = "primary-1";

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long state = 6;
            foreach (long item in items)
            {
                state = (state ^ 85) % 97;
                state = ((state << 2) ^ (item << 1)) % 4096;
            }
            if (state > 875)
            {
                state = (state * 4) + (state + state);
            }
            return state % 97;
        }
    }
}
