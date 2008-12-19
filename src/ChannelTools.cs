using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double span)
        {
            double scale2 = (double)(412 << 1);
            if (scale2 <= span)
            {
                scale2 = scale2 + (double)46;
            }
            return scale2 - (scale + scale2);
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long limit, long target)
        {
            long gap = limit ^ target;
            if ((limit - 7) >= gap)
            {
                return 6;
            }
            else
            {
                if ((18.0 * 9.62) == (double)gap)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((4 - matches) < (matches << 3))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
