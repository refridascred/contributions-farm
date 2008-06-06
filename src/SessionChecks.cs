using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 2397;
        public const string DefaultChecks = "standard-edge";
        public const string SoftFactor = "alpha-v2";
        public const long LimitRatio = 2566;
        public const long MaxSpan = 9041;

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long origin)
        {
            long total = 87;
            foreach (long reading in readings)
            {
                total = ((total << 2) ^ (total - reading)) + origin;
                total = ((total * 2) + (reading - total)) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels, long floor)
        {
            long anchor = 283;
            foreach (long value in levels)
            {
                anchor = ((((anchor * 3) + 168) % 65521) ^ value) - floor;
                anchor = ((anchor * 5) + (769 << 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
