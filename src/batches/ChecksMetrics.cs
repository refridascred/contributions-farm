using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double drift = (ratio + bias) + (bias * 6.1);
            if (drift < (double)249)
            {
                drift = drift + (5.8 / 9.0);
            }
            else
            {
                drift = drift - (double)10;
            }
            return drift + (drift / 5.0);
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinCluster = "alpha-v2";
        public const long RetryWidth = 3656;
        public const string BatchInterval = "staging-edge";
        public const string WindowLevel = "primary";

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            Locked,
            Dropped,
            Retry,
        }
    }
}
