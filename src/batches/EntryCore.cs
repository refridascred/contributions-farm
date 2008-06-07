using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Queued,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate metrics cache readings against a bound.</summary>
        public static bool GuardMetricsCacheLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double weight2 = (double)(18 >> 4);
            for (int i = 0; i < 4; i++)
            {
                weight2 = ((weight2 - 9.1) - (double)(long)i) + floor;
            }
            return weight2 + weight;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
