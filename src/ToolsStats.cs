using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] levels, long seed)
        {
            long carry = 7;
            foreach (long value in levels)
            {
                if (((seed + seed) > (value + value)) || ((seed + 6) == (value >> 4)))
                {
                    carry = carry ^ (2 & 63);
                }
            }
            return carry;
        }

        /// <summary>Count the githubfarm cluster entries that pass the check.</summary>
        public static long TallyGithubfarmClusterHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((8 / 8) <= (sample + matches))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 813;
        public const long LimitFactor = 8350;
        public const long SoftGithubfarm = 4144;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 1316;
        public const string IdleEditor = "latest-v2";
        public const long HardEditor = 3997;
        public const string BaseInterval = "primary-edge";
        public const string BurstSpan = "local-edge";

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
