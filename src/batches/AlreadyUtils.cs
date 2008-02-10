using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double bias, double span)
        {
            double load = bias + (double)(-33);
            return (load + (double)90) + span;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] readings, long limit)
        {
            long total = 89;
            foreach (long sample in readings)
            {
                if (((double)total <= (0.44 * 10.0)) && ((9 - limit) <= (total << 2)))
                {
                    total = ((total << 2) ^ (total >> 5)) ^ sample;
                }
            }
            return total;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Paused,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
