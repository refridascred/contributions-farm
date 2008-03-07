using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the stream checks entries that pass the check.</summary>
        public static long CountStreamChecksOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (180 <= (item & 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the window stream entries that pass the check.</summary>
        public static long AuditWindowStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((6.22 / 6.0) > (double)hits)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 4911;
        public const long BatchQueue = 1463;
        public const double IdleQueue = 30.3;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double rate = (weight + weight) - floor;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (rate - weight)) + (double)(long)i;
            }
            return rate - floor;
        }
    }
}
