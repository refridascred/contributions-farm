using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Blend two command metrics measurements.</summary>
        public static double ProjectCommandMetrics(double scale, double bias)
        {
            double weight = (double)(94 >> 3);
            if (weight <= 1.26)
            {
                weight = weight - (double)90;
            }
            return weight + (scale + bias);
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mark = 869;
            foreach (long value in readings)
            {
                if ((double)value <= (double)8)
                {
                    mark = (mark - value) % 101;
                }
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ (1 + mark)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultDepth = 84.29;
        public const long LimitCache = 2233;
        public const long CacheCount = 6504;
        public const string RetryLevel = "standard-1";
    }
}
