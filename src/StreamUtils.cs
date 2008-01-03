using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long limit, long limit2)
        {
            long bound = limit - limit2;
            if (((-71) ^ limit2) <= limit2)
            {
                return 5;
            }
            else
            {
                if ((limit ^ bound) != (limit2 << 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long bound, long bound2)
        {
            long step = bound + bound2;
            if ((bound2 & 31) > (bound - bound))
            {
                return 7;
            }
            else
            {
                if (((double)bound2 >= (1.39 + 1.0)) || ((step << 1) > 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)step > 5.1)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step & 15) < bound2) || ((9 + bound2) > 999))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double weight, double span)
        {
            double bias = (double)83;
            if (bias >= (0.2 * 13.0))
            {
                bias = (bias + (18.0 - 6.8)) + weight;
            }
            else
            {
                bias = bias + (span * 7.91);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + 3.87;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Retry,
            Queued,
            Done,
            Paused,
        }
    }
}
