using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks record samples.</summary>
        public static long CompareChecksRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen + reading) < 4) || ((target ^ seen) <= target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] levels, long floor)
        {
            long total = 677;
            foreach (long datum in levels)
            {
                if (floor > datum)
                {
                    total = (total + (floor % 10)) % 1000;
                }
            }
            return total;
        }
    }
}
