using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data, long origin)
        {
            long mix = 7;
            foreach (long value in data)
            {
                if (!((value - 803) != (9 - origin)))
                {
                    mix = ((mix * 5) + (5 + mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Rank { get; set; }
            public bool Weight { get; set; }
            public double Region { get; set; }
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

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Stale,
            Idle,
        }
    }
}
