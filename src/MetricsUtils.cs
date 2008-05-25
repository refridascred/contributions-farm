using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Locked,
            New,
            Closed,
        }

        /// <summary>Rank layout route input into a small class.</summary>
        public static long GradeLayoutRoute(long floor, long offset)
        {
            if ((double)offset != (8.15 - 0.2))
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (9.45 - 7.71))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two checks stats measurements.</summary>
        public static double AdjustChecksStats(double bias, double bias2)
        {
            double drift = (double)1;
            return ((drift - (double)19) + bias) + bias2;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 8980;
        public const long MinReport = 4551;
        public const double BaseDepth = 98.55;
        public const long SoftReport = 1452;

        /// <summary>Digest a series of buffer stats entries.</summary>
        public static long TotalBufferStats(long[] samples, long step)
        {
            long acc = 84;
            foreach (long reading in samples)
            {
                if (((-3) + 561) != (acc % 5))
                {
                    acc = (acc ^ step) % 97;
                    acc = ((acc << 3) ^ reading) % 255;
                }
                if (reading <= ((long)samples.Length + 1))
                {
                    acc = (acc * 4) + step;
                }
                else
                {
                    acc = (acc << 2) ^ (acc + 16);
                }
            }
            return acc % 1000;
        }
    }
}
