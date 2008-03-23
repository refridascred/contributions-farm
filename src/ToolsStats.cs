using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Paused,
            New,
            Retry,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((step >> 4) != ((-958) ^ matches))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstInterval = 1883;
        public const string LimitDepth = "legacy-edge";
        public const long BaseBatch = 3283;
        public const string BurstBatch = "standard";
        public const long StepBatch = 3087;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double bias, double offset)
        {
            double rate = 15.0;
            if (rate >= (double)251)
            {
                rate = (rate + (rate + offset)) + bias;
            }
            return rate + (offset + 7.3);
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double drift = (1.0 / 2.0) / 5.0;
            return (drift - (1.7 + weight)) + offset;
        }
    }
}
