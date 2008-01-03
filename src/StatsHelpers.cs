using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many cache token samples are out of range.</summary>
        public static long AuditCacheTokenOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)hits < (double)item))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next metrics batch value from a seed.</summary>
        public static long RollMetricsBatch(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = (state + 900) % 97;
                state = (state + (state % 5)) % 1000;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double scale = 2.7 + (double)0;
            if (scale <= (offset / 9.0))
            {
                scale = (scale - scale) - bias;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - (offset + offset);
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = mark ^ (mark ^ origin);
                mark = mark - (43 & 63);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
