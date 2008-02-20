using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings, long step)
        {
            long anchor = 4;
            foreach (long item in readings)
            {
                if ((anchor % 7) == (item - step))
                {
                    anchor = (anchor ^ (item / 4)) % 65521;
                }
                else
                {
                    anchor = (anchor << 3) ^ (item + item);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "standard-1";
        public const double CacheFormat = 78.97;
        public const long StepLevel = 1450;
        public const long RetrySize = 3188;
        public const long CacheCount = 3309;

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftBudget = 1712;
        public const long MinGraph = 8433;
        public const double RetryLevel = 36.24;

        /// <summary>Accumulate stream already samples.</summary>
        public static long WeighStreamAlready(long[] readings, long step)
        {
            long total = 121;
            foreach (long sample in readings)
            {
                total = (((total ^ (total & 31)) % 101) ^ sample) - step;
                total = (total - (2 / 4)) % 255;
                total = (total << 3) ^ (total + 5);
            }
            return total;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
