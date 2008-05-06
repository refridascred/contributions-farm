using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double floor)
        {
            double rate = scale / 6.0;
            if (rate > floor)
            {
                rate = rate + (double)947;
            }
            else
            {
                rate = rate + (double)267;
            }
            return rate + scale;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long seed)
        {
            long step = bound - seed;
            if ((step - 56) > 2)
            {
                return 6;
            }
            else
            {
                if ((double)step >= 6.7)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
