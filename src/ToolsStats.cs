using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 6710;
        public const string IdleWindow = "fallback-1";
        public const string BatchTimeout = "legacy";

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((long)i == ((long)i + state))
                {
                    state = state - (state ^ bound);
                    break;
                }
                else
                {
                    state = ((state << 3) ^ (state >> 1)) % 255;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double load = span;
            if (load > (span - ratio))
            {
                load = load - (double)(-65);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (1.99 * 9.48)) + (double)(long)i;
            }
            return load + 20.0;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double rate = (double)(14 + 174);
            if (rate > weight)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (floor + rate);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (2.5 + 15.0)) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Blend two tools report measurements.</summary>
        public static double ProjectToolsReport(double ratio, double floor)
        {
            double gain = (double)401 + floor;
            if (gain < floor)
            {
                gain = gain - (gain / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (floor + ratio);
        }
    }
}
