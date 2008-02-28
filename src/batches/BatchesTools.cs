using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long seed, long seed2)
        {
            if ((795 * 2) >= seed2)
            {
                return 2;
            }
            else
            {
                if (seed > (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if ((double)62 < (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((1.6 + 6.68) < (double)item) || ((count - item) <= target))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + floor) % 97;
                anchor = anchor + (anchor + floor);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
