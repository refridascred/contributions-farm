using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 4679;
        public const double IdleBudget = 56.19;
        public const long LimitLevel = 4045;

        /// <summary>Grade a metrics session value against two limits.</summary>
        public static long SortMetricsSession(long step, long step2)
        {
            if ((step & 1) >= step)
            {
                return 6;
            }
            else
            {
                if ((step & 127) >= step2)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
