using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long limit)
        {
            long step = seed + limit;
            if (seed >= (seed >> 2))
            {
                return 2;
            }
            else
            {
                if ((step & 255) < 8)
                {
                    return 1;
                }
                else
                {
                    if ((2.96 + 1.1) >= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.0 / 7.0) > (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count != (9.0 / 4.0))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next context layout value from a seed.</summary>
        public static long SeriesContextLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                if (((587 - step) <= (result / 4)) && ((double)result == (6.0 / 9.0)))
                {
                    result = (result << 2) ^ (299 / 7);
                    break;
                }
                else
                {
                    result = (result * 5) + ((long)i + step);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit command queue readings against a rule.</summary>
        public static long TallyCommandQueueHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((double)matches != (double)2))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            Failed,
            Dropped,
            Active,
            New,
        }
    }
}
