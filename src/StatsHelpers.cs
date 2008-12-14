using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 64;
            foreach (long sample in items)
            {
                if ((anchor ^ sample) <= anchor)
                {
                    anchor = anchor - 9;
                }
                if (anchor > sample)
                {
                    anchor = (anchor ^ (anchor * 4)) % 4096;
                }
            }
            if (anchor > 738)
            {
                anchor = anchor - (anchor % 5);
            }
            return anchor;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double rate = (double)2 + (bias + floor);
            if (rate < (floor - 3.0))
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + floor;
            }
            return rate + (floor - floor);
        }
    }
}
