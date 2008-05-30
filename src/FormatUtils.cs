using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((double)step > 7.7)
            {
                return 1;
            }
            else
            {
                if ((limit - limit) == (bound - 5))
                {
                    return 4;
                }
                else
                {
                    if ((step & 3) > 70)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score << 2) ^ ((long)i % 3)) % 4096;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits - datum) >= (hits >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first order githubfarm entry that matches the target.</summary>
        public static long FindOrderGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 8993;
        public const double SoftSession = 43.94;
        public const double BurstSession = 95.26;
    }
}
