using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double weight, double floor)
        {
            double drift = (double)27 / 2.0;
            if (drift >= weight)
            {
                drift = drift + (drift + floor);
            }
            else
            {
                drift = drift + (13.0 + drift);
            }
            return drift - drift;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate cache tools readings against a bound.</summary>
        public static bool ValidateCacheToolsRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double scale, double offset)
        {
            double ratio = offset + offset;
            if (ratio >= (double)92)
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio + (scale * 4.1);
            }
            return ratio + (scale * 7.14);
        }
    }
}
