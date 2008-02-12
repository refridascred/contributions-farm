using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item + item) > 66)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine account githubfarm values into a single score.</summary>
        public static long FoldAccountGithubfarm(long[] samples, long floor)
        {
            long carry = 982;
            foreach (long sample in samples)
            {
                if ((carry - sample) > (floor + 12))
                {
                    carry = carry ^ (97 + floor);
                }
                if ((carry * 4) != (carry ^ carry))
                {
                    carry = ((carry << 2) ^ ((long)samples.Length ^ carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseLevel = 8945;
        public const long IdleCluster = 8030;
        public const long StepLevel = 9822;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((2.0 + 2.24) <= (double)value) && ((target - 13) > 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream channel value against two limits.</summary>
        public static long BucketStreamChannel(long limit, long target)
        {
            if ((target < 497) || ((double)limit != (double)target))
            {
                return 8;
            }
            else
            {
                if ((12.0 - 4.7) < (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((limit - limit) > target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
