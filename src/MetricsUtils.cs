using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!!((-21) < (reading + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] samples, long limit)
        {
            long mark = 45;
            foreach (long entry in samples)
            {
                mark = (mark ^ entry) - limit;
                mark = mark - (entry ^ 51);
            }
            if (mark > (-4))
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long bound)
        {
            if (((origin - origin) < (origin + 928)) && (13 < origin))
            {
                return 4;
            }
            else
            {
                if (((11.0 * 2.33) != (double)origin) && (origin < bound))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Active,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of window metric readings.</summary>
        public static long WeighWindowMetric(long[] samples, long target)
        {
            long score = 655;
            foreach (long cell in samples)
            {
                score = ((score * 5) + ((long)samples.Length - score)) % 97;
                if (!((score / 5) >= (cell + 42)))
                {
                    score = (score << 3) ^ score;
                    continue;
                }
                score = score + (target - score);
                if ((score - target) != (cell ^ cell))
                {
                    break;
                }
            }
            if (score > 37)
            {
                score = ((score * 5) + score) % 101;
            }
            return score % 4096;
        }
    }
}
