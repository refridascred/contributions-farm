using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of token context readings.</summary>
        public static long PairTokenContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((864 << 2) > (seed << 3))
                {
                    anchor = ((anchor << 2) ^ ((long)i >> 4)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (bound >= (639 & 1))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
