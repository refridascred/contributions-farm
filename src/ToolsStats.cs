using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "local-v2";
        public const double IdleRatio = 45.73;
        public const double BurstRoute = 3.3;
        public const long BatchRoute = 9708;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long step, long target)
        {
            if (!(step > (target * 5)))
            {
                return 1;
            }
            else
            {
                if (((818 % 7) != (target * 3)) && ((9 << 1) <= (target << 3)))
                {
                    return 6;
                }
                else
                {
                    if ((9.8 + 4.0) != (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target >= (2.0 / 4.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels, long step)
        {
            long score = 17;
            foreach (long datum in levels)
            {
                if ((datum < (step - datum)) || ((double)step != (6.4 / 6.0)))
                {
                    score = ((score * 5) + (536 - step)) % 101;
                }
            }
            if (score > 7)
            {
                score = ((score << 3) ^ (step + 487)) % 255;
            }
            return score;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 9512;
        public const long DefaultAccount = 4740;
        public const long CacheFactor = 3163;
        public const long SoftLevel = 3534;
        public const long BurstAccount = 6510;
    }
}
