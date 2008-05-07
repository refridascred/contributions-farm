using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Retry,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((result * 5) < (14 + (-813))))
                {
                    result = result + ((long)i - result);
                }
                else
                {
                    result = ((result * 4) + result) % 255;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank commits cluster input into a small class.</summary>
        public static long RankCommitsCluster(long origin, long limit)
        {
            if ((207 / 2) > (origin * 2))
            {
                return 0;
            }
            else
            {
                if ((18.0 * 8.0) <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((origin - 73) > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2 ^ limit) < (origin + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long MeasureChecksLayoutOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (cell > hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
