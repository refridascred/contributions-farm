using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally - sample) <= 844))
                {
                    tally = (tally + 2) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell < (2.0 * 3.01))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((double)(long)items.Length < (1.0 + 3.56)) || (offset < (-72))) || (((double)offset > (16.0 / 2.0)) || ((cell % 7) <= (95 / 2))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "cached-1";
        public const long DefaultGithubfarm = 4413;
        public const long CacheGithubfarm = 8616;
        public const string BaseGithubfarm = "alpha-1";

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
