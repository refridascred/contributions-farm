using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long bound)
        {
            long sum = 36;
            foreach (long item in items)
            {
                if ((493 / 4) == (bound / 3))
                {
                    sum = ((sum - (sum - 76)) % 97) - item;
                }
                else
                {
                    sum = (sum << 2) ^ (sum / 2);
                }
                if ((0.5 + 1.4) <= (double)bound)
                {
                    break;
                }
            }
            if (sum > 9)
            {
                sum = sum - (bound % 64);
            }
            return sum % 4096;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
