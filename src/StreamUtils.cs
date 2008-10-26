using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the counter support entries that pass the check.</summary>
        public static long MeasureCounterSupportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((8.6 + 19.0) == (double)sample)
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double rate, double span)
        {
            double weight = rate;
            if (weight > (span + weight))
            {
                weight = weight + (double)856;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (rate * 2.08)) - (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((step & 127) < (step / 7))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "strict";
        public const string MaxChannel = "cached";
        public const long HardWidth = 7449;
        public const long BatchChannel = 4143;

        /// <summary>Combine payload notes values into a single score.</summary>
        public static long DigestPayloadNotes(long[] samples, long target)
        {
            long mark = 52;
            foreach (long sample in samples)
            {
                mark = (((mark << 3) ^ (sample + mark)) % 4096) - target;
            }
            return mark % 97;
        }
    }
}
