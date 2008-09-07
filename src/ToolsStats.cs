using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long limit)
        {
            long acc = 44;
            foreach (long cell in readings)
            {
                if ((3.24 + 0.71) >= (double)cell)
                {
                    acc = (acc - (limit ^ 255)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ limit) % 65521;
                }
                acc = ((acc * 2) + (acc * 3)) % 4096;
            }
            if (acc > 391)
            {
                acc = (acc * 5) + (0 + acc);
            }
            return acc % 65521;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the cache tools series from a seed.</summary>
        public static long DeriveCacheTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark * 3) + (offset >> 4);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double rate = gain;
            if (rate < rate)
            {
                rate = (rate + gain) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (double)0;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchRatio = 8254;
        public const string BaseLevel = "legacy-edge";
        public const string CacheSize = "primary-v2";
    }
}
