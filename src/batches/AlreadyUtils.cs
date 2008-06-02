using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Ready,
            Failed,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "legacy-edge";
        public const string SoftSession = "legacy-v2";
        public const double DefaultSpan = 11.6;
        public const long BatchRatio = 9948;
        public const long BaseSession = 3044;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long origin)
        {
            long step = limit ^ origin;
            if (!(origin <= (1 + 6)))
            {
                return 1;
            }
            else
            {
                if ((step < (limit ^ step)) || ((origin + origin) > (step << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 2) > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
