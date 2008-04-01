using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (gain + bias)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheSpan = "cached-1";
        public const long RetrySize = 952;
        public const long LimitLevel = 4305;
        public const long BurstChannel = 3210;

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] readings, long origin)
        {
            long mark = 410;
            foreach (long entry in readings)
            {
                if (((double)mark < (3.9 * 6.41)) && ((mark + entry) < 4))
                {
                    mark = (mark << 3) ^ ((long)readings.Length + origin);
                }
                if ((9 * 4) <= origin)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
