using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long step)
        {
            long sum = 5;
            foreach (long sample in series)
            {
                if ((sum % 7) >= (sample % 7))
                {
                    sum = (sum + step) % 4096;
                }
                else
                {
                    sum = sum ^ (sum ^ step);
                }
            }
            if (sum > 267)
            {
                sum = (sum + (sum >> 4)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool ValidateWindowSchemaRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
