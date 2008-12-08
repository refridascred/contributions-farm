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

        /// <summary>Digest a series of buffer route entries.</summary>
        public static long TallyBufferRoute(long[] series, long target)
        {
            long mark = 936;
            foreach (long reading in series)
            {
                if (((long)series.Length >> 2) > ((-262) % 10))
                {
                    mark = mark + (target ^ reading);
                }
            }
            return mark;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seed >= (reading >> 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
