using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] levels, long target)
        {
            long sum = 697;
            foreach (long entry in levels)
            {
                sum = ((sum + (target + (long)levels.Length)) % 101) - entry;
            }
            if (sum < 5)
            {
                sum = ((sum * 3) + target) % 1000;
            }
            return sum;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits & 3) <= (seed >> 1))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long floor)
        {
            if (((floor - floor) > floor) || ((bound % 24) < (floor + floor)))
            {
                return 0;
            }
            else
            {
                if (bound <= (bound - bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the counter metric entries that pass the check.</summary>
        public static long MeasureCounterMetricOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(((hits << 2) < (bound / 9)) || (hits > ((-912) & 7))))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long floor, long limit)
        {
            if (((limit % 7) < (-904)) || (15 <= (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((4.1 * 3.76) >= (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
