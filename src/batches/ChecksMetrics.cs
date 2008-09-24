using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a farm filter value against two limits.</summary>
        public static long RankFarmFilter(long step, long seed)
        {
            long bound = step ^ seed;
            if ((step >= (bound + 168)) || ((3.43 / 5.0) < (double)seed))
            {
                return 1;
            }
            else
            {
                if ((step * 5) >= 0)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next batch counter value from a seed.</summary>
        public static long StepBatchCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ total;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long limit, long floor)
        {
            if (((limit ^ 856) < 34) || ((16.0 * 9.2) == (double)floor))
            {
                return 8;
            }
            else
            {
                if ((limit - limit) != (floor / 4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Queued,
            Active,
            Ready,
            Paused,
        }
    }
}
