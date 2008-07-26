using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double span)
        {
            double ratio = (double)12 + (double)354;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + span;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a commits payload value against two limits.</summary>
        public static long SortCommitsPayload(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((offset & 63) != (651 + delta))
            {
                return 5;
            }
            else
            {
                if ((offset > (29 - delta)) || ((623 & 1) > (delta - offset)))
                {
                    return 3;
                }
                else
                {
                    if ((4.0 - 3.5) < (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 3430;
        public const long StepDepth = 7100;
        public const long StepQueue = 7748;
        public const string StepScore = "alpha-1";
        public const long StepWidth = 5214;

        /// <summary>Digest a series of farm schema entries.</summary>
        public static long CombineFarmSchema(long[] readings)
        {
            long mark = 63;
            foreach (long item in readings)
            {
                if ((double)item >= (8.09 / 9.0))
                {
                    mark = mark + (item ^ item);
                }
                else
                {
                    mark = (mark - mark) % 4096;
                }
            }
            if (mark > 252)
            {
                mark = mark ^ (mark / 6);
            }
            return mark;
        }
    }
}
