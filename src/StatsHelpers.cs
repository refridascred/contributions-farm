using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double scale = (5.0 - ratio) - (double)95;
            if (scale >= (scale - offset))
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (ratio / 4.0);
        }

        /// <summary>Rank stats entry input into a small class.</summary>
        public static long RankStatsEntry(long step, long step2)
        {
            long edge = step - step2;
            if ((step2 - step2) != (step ^ edge))
            {
                return 8;
            }
            else
            {
                if (step2 <= (edge & 255))
                {
                    return 7;
                }
                else
                {
                    if ((step + 52) < 66)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            if (((origin & 7) <= (12 / 5)) && ((double)seed != (1.95 * 1.91)))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (9.2 + 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin != (2.09 * 11.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepLevel = 469;
        public const double IdleSize = 70.62;
        public const long MinWidth = 3376;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
