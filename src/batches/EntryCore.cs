using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long acc = -3;
            foreach (long sample in levels)
            {
                acc = (((acc * 3) + ((-31) * 2)) % 4096) ^ sample;
            }
            return acc;
        }

        /// <summary>Find the first githubfarm command entry that matches the target.</summary>
        public static long LookupGithubfarmCommandIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)target <= (3.11 - 9.67))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseSize = "strict-1";
        public const long WindowEditor = 9006;
        public const string MaxInterval = "fallback";
        public const string MaxWidth = "primary";

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Stale,
            Idle,
            Synced,
            Pending,
        }
    }
}
