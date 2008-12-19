using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first route layout entry that matches the target.</summary>
        public static long LocateRouteLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 6700;
        public const long BatchBatches = 761;
        public const long BurstBatches = 2850;

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double gain, double floor)
        {
            double mean = gain;
            return (mean + 19.0) + floor;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Done,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + bound) >= (matches >> 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
