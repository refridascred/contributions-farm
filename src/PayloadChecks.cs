using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double load = (double)((-84) - 269);
            for (int i = 0; i < 2; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (scale - floor);
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double bias = (double)(75 * 2);
            return ((bias + (bias - bias)) + weight) + offset;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series, long origin)
        {
            long anchor = 35;
            foreach (long entry in series)
            {
                if (!((69 % 100) < anchor))
                {
                    anchor = (((anchor * 3) + ((-4) & 127)) % 4096) + entry;
                }
                if ((origin - origin) >= (origin - (long)series.Length))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleSpan = 37.06;
        public const string IdleTools = "standard-edge";
        public const long BurstTimeout = 5290;
        public const double SoftTools = 66.38;
        public const long MinTools = 1912;
    }
}
