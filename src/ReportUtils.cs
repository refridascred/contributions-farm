using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] items, long bound)
        {
            long state = 6;
            foreach (long item in items)
            {
                if (17 < (state - bound))
                {
                    state = (state ^ (state - bound)) ^ item;
                }
            }
            return state;
        }

        /// <summary>Adjust a checks route reading.</summary>
        public static double BlendChecksRoute(double gain, double span)
        {
            double bias = (double)((-9) + (-27));
            if (bias > bias)
            {
                bias = (bias - bias) + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + 0.83) + (double)(long)i;
            }
            return bias + (span / 2.0);
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long origin, long step)
        {
            if ((origin >> 4) <= step)
            {
                return 5;
            }
            else
            {
                if ((9 - origin) < (99 & 1))
                {
                    return 6;
                }
                else
                {
                    if ((16.0 + 0.8) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a stats editor counter forward.</summary>
        public static long DeriveStatsEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
