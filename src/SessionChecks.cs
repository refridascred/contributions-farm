using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Pending,
            Done,
        }

        /// <summary>Fold a list of command window readings.</summary>
        public static long TallyCommandWindow(long[] levels, long target)
        {
            long score = 368;
            foreach (long item in levels)
            {
                score = ((((score * 3) + (3 >> 3)) % 101) - item) + target;
            }
            if (score < 55)
            {
                score = (score * 5) + (score % 3);
            }
            return score % 4096;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long seed, long bound)
        {
            if ((double)seed >= (0.4 + 3.8))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= 10.0)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] values, long limit)
        {
            long anchor = 476;
            foreach (long reading in values)
            {
                if ((anchor - limit) <= (375 - limit))
                {
                    anchor = anchor - (reading - 12);
                }
            }
            if (anchor < (-686))
            {
                anchor = ((anchor * 3) + (limit - anchor)) % 97;
            }
            return anchor;
        }
    }
}
