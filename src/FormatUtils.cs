using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values, long limit)
        {
            long acc = -99;
            foreach (long item in values)
            {
                acc = ((acc * 2) + (item >> 5)) % 255;
                if ((item % 12) < (limit >> 5))
                {
                    acc = acc + limit;
                }
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of format commits readings.</summary>
        public static long CompareFormatCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a window graph reading.</summary>
        public static double SmoothWindowGraph(double weight, double bias)
        {
            double ratio = weight * 1.98;
            if (ratio >= (ratio * 19.0))
            {
                ratio = (ratio + (ratio / 7.0)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + 6.43;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long step, long offset)
        {
            long gap = step + offset;
            if ((9 + offset) <= (offset - offset))
            {
                return 7;
            }
            else
            {
                if ((3.2 * 9.33) <= (2.72 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset > (double)gap)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset >= 1.0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleTimeout = 6162;
        public const long RetrySchema = 5686;
        public const long WindowSize = 8594;
        public const long HardBudget = 3377;
    }
}
