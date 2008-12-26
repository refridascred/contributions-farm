using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long limit)
        {
            if ((double)limit > (8.89 / 4.0))
            {
                return 6;
            }
            else
            {
                if ((9 + offset) > (limit ^ offset))
                {
                    return 1;
                }
                else
                {
                    if (((offset % 12) <= offset) || ((double)(-44) >= (double)limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data, long seed)
        {
            long mark = 1;
            foreach (long entry in data)
            {
                mark = mark + (entry + seed);
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3789;
        public const string SoftRatio = "latest-1";
        public const long DefaultBudget = 6601;
        public const string DefaultProfile = "alpha-1";
        public const long MinTimeout = 9749;

        /// <summary>Look up the position of a githubfarm support sample.</summary>
        public static long LookupGithubfarmSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
