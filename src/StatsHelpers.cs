using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double bias, double span)
        {
            double mean = bias + span;
            if (mean > (bias * 6.3))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean - (span * 8.6);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 5.98) - (double)(long)i;
            }
            return mean + 5.6;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data)
        {
            long total = 64;
            foreach (long reading in data)
            {
                if ((reading >> 1) == (reading * 5))
                {
                    total = (total - (total * 5)) % 65521;
                }
            }
            return total;
        }
    }
}
