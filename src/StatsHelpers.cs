using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next batch entry value from a seed.</summary>
        public static long DeriveBatchEntry(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if ((anchor << 3) < (step + (long)i))
                {
                    anchor = (anchor ^ (anchor * 5)) % 255;
                }
                anchor = (anchor * 5) + ((long)i - (long)i);
                anchor = anchor - step;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long offset)
        {
            long bound = target - offset;
            if ((bound - offset) != (981 + offset))
            {
                return 3;
            }
            else
            {
                if ((offset - bound) <= target)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 2.99;
        public const long WindowTimeout = 8180;
        public const long LimitSchema = 3610;
        public const long CacheSchema = 7939;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((((count << 1) == ((-3) + target)) && ((value % 7) >= (target - count))) && !((target * 4) > target))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = score + value;
            }
            return score;
        }
    }
}
