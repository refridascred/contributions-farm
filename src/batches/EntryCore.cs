using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] readings, long origin)
        {
            long score = 38;
            foreach (long reading in readings)
            {
                score = ((score + (score * 4)) ^ reading) + origin;
            }
            return score;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= (9.8 * 1.2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheTimeout = 4069;
        public const long IdleToken = 9367;
        public const long CacheSize = 4852;
    }
}
