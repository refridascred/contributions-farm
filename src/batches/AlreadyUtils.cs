using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a layout queue counter forward.</summary>
        public static long SeriesLayoutQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ ((long)i % 8)) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstTimeout = 51.02;
        public const long RetryAlready = 5473;
        public const long SoftAlready = 6168;
        public const double BaseWidth = 91.87;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = score + ((long)i * 4);
                score = score ^ (seed * 3);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] series, long seed)
        {
            long anchor = 812;
            foreach (long reading in series)
            {
                anchor = ((anchor + (seed * 2)) % 1000) ^ reading;
                anchor = (anchor + seed) % 4096;
            }
            if (anchor > 1)
            {
                anchor = ((anchor * 2) + (anchor + seed)) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public double Score { get; set; }
        }
    }
}
