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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long seed)
        {
            if (seed > (offset / 8))
            {
                return 8;
            }
            else
            {
                if (((seed + seed) <= offset) || ((63 + seed) > seed))
                {
                    return 1;
                }
                else
                {
                    if ((7.0 - 1.2) != (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
