using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first editor githubfarm entry that matches the target.</summary>
        public static long LocateEditorGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long offset, long origin)
        {
            long lane = offset ^ origin;
            if (origin > (34 + lane))
            {
                return 6;
            }
            else
            {
                if ((origin - origin) >= (810 - origin))
                {
                    return 5;
                }
                else
                {
                    if (!((origin >> 2) == (0 / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 2312;
        public const string BaseOrder = "standard-edge";
        public const long MinOrder = 7199;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit queue format readings against a rule.</summary>
        public static long TallyQueueFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((5 << 3) >= sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
