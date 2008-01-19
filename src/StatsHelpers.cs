using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((-3) <= ((long)data.Length - seen)))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Adjust a payload channel reading.</summary>
        public static double AdjustPayloadChannel(double scale, double floor)
        {
            double mean = 2.1;
            for (int i = 0; i < 6; i++)
            {
                mean = (((mean - 1.3) - (double)(long)i) + scale) - floor;
            }
            return mean - (double)441;
        }
    }
}
