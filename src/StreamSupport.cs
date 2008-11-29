using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Paused,
            Locked,
            Draft,
        }

        /// <summary>Count the session command entries that pass the check.</summary>
        public static long TallySessionCommandGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((6.0 * 2.3) < (double)item) || (((10.0 * 7.07) <= (double)bound) && ((bound + item) == (item + 539))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long limit)
        {
            if (((offset / 5) >= (limit % 7)) || (offset >= (limit * 5)))
            {
                return 6;
            }
            else
            {
                if ((limit - 65) < offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset < (offset ^ offset)) || ((limit << 3) > (limit << 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
