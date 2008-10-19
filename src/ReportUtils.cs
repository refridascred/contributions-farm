using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit order counter readings against a rule.</summary>
        public static long CountOrderCounterOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item + item) > (count / 7))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Done,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long seed, long offset)
        {
            if ((double)seed == (9.4 + 4.0))
            {
                return 3;
            }
            else
            {
                if ((offset / 9) == (seed ^ offset))
                {
                    return 1;
                }
                else
                {
                    if (((seed - 753) <= offset) && ((151 + offset) <= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (733 > (seed << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] values)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (mark ^ (cell + mark)) % 101;
                    mark = (mark + ((long)i << 3)) % 65521;
                }
                mark = ((mark << 3) ^ cell) % 255;
                mark = (mark ^ (cell % 60)) % 1000;
            }
            return mark;
        }
    }
}
