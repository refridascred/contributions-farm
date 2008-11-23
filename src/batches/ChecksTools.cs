using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowSpan = "legacy";
        public const long WindowGraph = 6042;
        public const long MinWidth = 1198;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next githubfarm batch value from a seed.</summary>
        public static long SeriesGithubfarmBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                long tally = mark;
                mark = (mark << 3) ^ (tally - (long)i);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
