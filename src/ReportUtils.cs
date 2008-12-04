using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next notes support value from a seed.</summary>
        public static long IterateNotesSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit <= 87)
                {
                    mark = (mark * 5) + limit;
                    mark = (mark - limit) % 101;
                }
                else
                {
                    mark = (mark - (limit / 7)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long origin)
        {
            if ((double)origin == (1.9 + 4.0))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) == (bound << 2))
                {
                    return 3;
                }
                else
                {
                    if ((origin - bound) < (origin / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4 - bound) >= bound)
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
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 2972;
        public const double IdleFormat = 89.34;
        public const long CacheFormat = 6550;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
