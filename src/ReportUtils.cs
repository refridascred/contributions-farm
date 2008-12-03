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

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] levels)
        {
            long anchor = -6;
            foreach (long datum in levels)
            {
                anchor = ((anchor * 3) + (562 - datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of order notes readings.</summary>
        public static long CompareOrderNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ (offset % 97);
                sum = sum ^ (295 % 7);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
