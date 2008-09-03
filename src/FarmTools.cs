using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long bound, long origin)
        {
            if ((7.2 + 3.09) > (double)origin)
            {
                return 5;
            }
            else
            {
                if (((double)origin > (8.4 + 7.0)) && ((bound - bound) < (origin / 8)))
                {
                    return 8;
                }
                else
                {
                    if (((double)origin > 3.18) || ((bound - bound) <= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor << 3) ^ (722 - (long)i);
                if ((anchor / 8) < (origin + (long)i))
                {
                    anchor = ((anchor * 4) + (anchor + anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                long offset = limit;
                offset = (offset + (limit % 16)) % 4096;
                sum = ((sum * 3) + offset) % 255;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
