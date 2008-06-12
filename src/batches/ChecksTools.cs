using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell & 63) <= count) || ((count / 6) >= (count ^ 479)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 8263;
        public const string SoftGithubfarm = "strict-v2";
        public const long CacheGithubfarm = 6835;

        /// <summary>Rank order record input into a small class.</summary>
        public static long BucketOrderRecord(long floor, long offset)
        {
            if (!((floor + floor) >= offset))
            {
                return 7;
            }
            else
            {
                if ((offset - floor) < 214)
                {
                    return 6;
                }
                else
                {
                    if (((double)floor <= (5.36 / 9.0)) || ((offset ^ offset) >= offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset << 2) != (offset >> 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((0 > (limit >> 3)) || ((4.82 + 20.0) != (double)reading)) || (((double)(long)series.Length >= (19.0 + 7.71)) && ((double)hits >= 16.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
