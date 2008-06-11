using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long step2)
        {
            long next = step + step2;
            if (((3 % 12) != (step & 15)) || ((step2 - 987) < step2))
            {
                return 6;
            }
            else
            {
                if ((step * 4) == (431 ^ step))
                {
                    return 3;
                }
                else
                {
                    if (!((9.38 * 5.67) > (double)step2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((next / 5) != (next * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading < (hits >> 2))
                {
                    hits = (hits + 3) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((52 & 31) > target)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
