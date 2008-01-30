using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] data, long limit)
        {
            long total = 90;
            foreach (long item in data)
            {
                total = ((total ^ limit) % 65521) - item;
                total = (total ^ total) % 65521;
                total = (total * 5) + (total - limit);
            }
            if (total > 893)
            {
                total = total + (limit + limit);
            }
            return total;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long origin, long origin2)
        {
            long cur = origin ^ origin2;
            if (((origin2 + origin2) < (origin2 % 3)) || (origin <= (-50)))
            {
                return 5;
            }
            else
            {
                if (((cur / 2) == (35 - origin2)) || (cur <= (origin + 1)))
                {
                    return 3;
                }
                else
                {
                    if ((origin + 96) == (origin >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            New,
            Queued,
            Pending,
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double gain, double span)
        {
            double scale = gain * 4.0;
            if (scale >= (gain + scale))
            {
                scale = scale - (double)196;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale - span)) + (double)(long)i;
            }
            return scale - (gain * 3.0);
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((double)entry > (6.4 - 7.0)) && ((matches + matches) >= ((long)data.Length << 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
