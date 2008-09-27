using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Weight { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double ratio, double offset)
        {
            double ratio2 = (double)(8 ^ (-996));
            if (ratio2 > (2.0 / 9.0))
            {
                ratio2 = (ratio2 - offset) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + 18.0) + (double)(long)i;
            }
            return ratio2 - (double)76;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
