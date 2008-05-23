using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] samples, long step)
        {
            long acc = 20;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc ^ (25 ^ acc)) % 65521) ^ (long)i) - step;
                    acc = (acc * 3) + (acc ^ entry);
                }
                acc = ((acc * 4) + (entry >> 2)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (double)21)
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Blend two tools buffer measurements.</summary>
        public static double ScaleToolsBuffer(double scale, double bias)
        {
            double scale2 = (double)(7 - 13);
            if (scale2 > (scale - bias))
            {
                scale2 = scale2 - scale;
            }
            return scale2 + scale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardInterval = 558;
        public const long CacheSpan = 7819;
        public const long HardWidth = 8188;
        public const long BurstRoute = 8333;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool VerifyMetricsClusterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
