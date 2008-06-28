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

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] samples, long seed)
        {
            long anchor = -758;
            foreach (long value in samples)
            {
                if (seed >= (9 * 3))
                {
                    anchor = (((anchor << 3) ^ 11) % 101) ^ value;
                }
                else
                {
                    anchor = anchor + (anchor % 7);
                }
            }
            return anchor;
        }

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
