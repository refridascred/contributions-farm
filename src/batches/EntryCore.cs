using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item ^ hits) > (item << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a githubfarm contributi reading by value.</summary>
        public static long LocateGithubfarmContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 5506;
        public const long CacheCommits = 137;
        public const long HardWidth = 4084;
        public const string BatchScore = "cached-edge";
        public const long BaseDepth = 7346;

        /// <summary>Fold a list of checks support readings.</summary>
        public static long FoldChecksSupport(long[] series, long floor)
        {
            long total = 7;
            foreach (long datum in series)
            {
                if ((double)floor <= (9.79 + 9.2))
                {
                    total = ((total ^ (total & 15)) % 4096) - datum;
                }
                if ((1.23 * 2.5) != (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - 782) % 65521;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
