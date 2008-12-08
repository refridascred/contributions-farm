using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double bias)
        {
            double load = bias;
            if (load >= (bias + ratio))
            {
                load = load + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)8 >= (double)bound)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long seed, long floor)
        {
            if ((1 & 15) < (seed - floor))
            {
                return 4;
            }
            else
            {
                if ((seed & 1) != (seed + seed))
                {
                    return 3;
                }
                else
                {
                    if ((16.0 * 17.0) <= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor >> 2) >= (seed >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
