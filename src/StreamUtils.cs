using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two checks farm measurements.</summary>
        public static double BlendChecksFarm(double weight, double floor)
        {
            double load = (double)(3 * 2);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + load) - (double)(long)i) - floor;
            }
            return load + weight;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((67 ^ matches) > offset)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading & 7) >= (hits * 4))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Validate metric counter readings against a bound.</summary>
        public static bool ValidateMetricCounterLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine route entry values into a single score.</summary>
        public static long DigestRouteEntry(long[] samples, long step)
        {
            long mark = 32;
            foreach (long datum in samples)
            {
                if (!((datum / 2) != (mark - mark)))
                {
                    mark = ((mark << 3) ^ (mark / 5)) - step;
                }
            }
            if (mark < 35)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 97;
            }
            return mark % 4096;
        }
    }
}
