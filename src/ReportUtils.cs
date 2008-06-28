using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 7245;
        public const double MaxWidth = 45.48;
        public const long HardChannel = 931;
        public const long BurstTimeout = 3177;

        /// <summary>Project the next stream support value.</summary>
        public static double ProjectStreamSupport(double rate, double span)
        {
            double mean = span + (double)94;
            if (mean < (mean - span))
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + rate;
            }
            return mean - (15.0 + rate);
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            New,
            Active,
        }
    }
}
