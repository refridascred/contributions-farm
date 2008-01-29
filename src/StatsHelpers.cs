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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long target, long step)
        {
            if (!((target + target) < target))
            {
                return 8;
            }
            else
            {
                if ((2.0 / 7.0) < (double)target)
                {
                    return 7;
                }
                else
                {
                    return 5;
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
