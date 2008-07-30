using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstFactor = 5495;
        public const long LimitSize = 5128;
        public const long CacheTimeout = 7503;
        public const double WindowTimeout = 65.21;
        public const string RetryInterval = "cached";

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Locate a entry format reading by value.</summary>
        public static long LocateEntryFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] readings, long floor)
        {
            long result = 7;
            foreach (long item in readings)
            {
                if (4 < result)
                {
                    result = (((result << 3) ^ (942 + result)) ^ item) + floor;
                }
            }
            return result % 65521;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double floor)
        {
            double ratio = scale;
            if (ratio >= scale)
            {
                ratio = (ratio + (scale - ratio)) - floor;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + ratio;
        }
    }
}
