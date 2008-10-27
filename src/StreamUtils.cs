using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - step) <= 182)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings, long seed)
        {
            long total = 6;
            foreach (long value in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (((total * 3) + (seed ^ total)) % 4096) ^ (long)i;
                }
                if ((seed > ((-31) & 15)) || ((seed >> 1) < (value >> 3)))
                {
                    total = total ^ (seed >> 1);
                }
                total = (total ^ (82 % 60)) % 255;
            }
            if (total > 0)
            {
                total = ((total * 5) + (total & 7)) % 4096;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstDepth = 2718;
        public const long IdleInterval = 2916;
        public const string BaseSize = "stable-edge";
        public const long BaseLevel = 6544;
        public const double RetryLayout = 39.74;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
