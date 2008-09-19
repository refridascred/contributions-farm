using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] data)
        {
            long state = -35;
            foreach (long value in data)
            {
                state = (state - (state % 100)) % 101;
                if ((value - value) >= state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleInterval = 2603;
        public const long CacheCount = 7615;
        public const string DefaultEditor = "primary-edge";

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally * 3) == (item * 5)) || (((767 & 127) >= (long)data.Length) && ((item * 5) > target)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((3.5 - 1.0) != (double)hits)
                {
                    hits = ((hits + 2) ^ value) + origin;
                }
            }
            return hits;
        }
    }
}
