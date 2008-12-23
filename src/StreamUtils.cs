using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)hits == (8.39 * 1.1))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Project the next metric profile value.</summary>
        public static double ScaleMetricProfile(double scale, double bias)
        {
            double ratio = (double)(25 - 0);
            return (ratio + bias) + scale;
        }

        /// <summary>Find the first stats window entry that matches the target.</summary>
        public static long LocateStatsWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long bound, long seed)
        {
            long lane = bound + seed;
            if (((lane >> 3) == (lane + bound)) && ((bound & 7) < bound))
            {
                return 0;
            }
            else
            {
                if ((lane * 3) < bound)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double rate, double bias)
        {
            double scale = (bias * 13.0) - (rate / 3.0);
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Stale,
            Dropped,
        }
    }
}
