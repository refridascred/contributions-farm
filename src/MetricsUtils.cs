using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long floor, long target)
        {
            long slot = floor + target;
            if ((double)slot != (7.1 + 0.1))
            {
                return 0;
            }
            else
            {
                if (((10 + floor) >= (slot % 2)) && ((12.0 - 8.24) != (double)floor))
                {
                    return 8;
                }
                else
                {
                    if (((double)floor > (double)slot) || ((target - slot) < ((-226) >> 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            New,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a order window reading by value.</summary>
        public static long LocateOrderWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "legacy";
        public const long MinRatio = 6838;
        public const long DefaultTimeout = 4500;
        public const string IdleAlready = "standard";
        public const string DefaultAlready = "open-1";
    }
}
