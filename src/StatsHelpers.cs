using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first cache githubfarm entry that matches the target.</summary>
        public static long LookupCacheGithubfarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((8.4 * 3.63) >= (double)matches)
                {
                    matches = ((matches + 2) + sample) - offset;
                }
            }
            return matches;
        }
    }
}
