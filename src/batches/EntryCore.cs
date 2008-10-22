using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double scale = (double)(5 << 1);
            return (scale + (floor + scale)) + gain;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long offset)
        {
            long cur = bound ^ offset;
            if (offset >= bound)
            {
                return 5;
            }
            else
            {
                if ((bound ^ bound) >= (offset - 54))
                {
                    return 7;
                }
                else
                {
                    if (!((double)cur > (1.0 / 3.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
