using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long limit, long floor)
        {
            if ((double)limit >= (12.0 * 2.1))
            {
                return 3;
            }
            else
            {
                if (((floor / 8) < (limit & 1)) && ((floor >> 5) != (floor * 4)))
                {
                    return 6;
                }
                else
                {
                    if ((892 - limit) <= (floor * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)limit != (10.0 * 2.96)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item - 91) > (item + 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "fallback-1";
        public const string HardContributi = "legacy-edge";
        public const long BatchSpan = 1208;
        public const double CacheContributi = 7.81;

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
