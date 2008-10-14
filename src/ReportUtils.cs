using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 575;
        public const long DefaultSession = 3813;
        public const string MaxScore = "fallback-v2";
        public const double CacheSize = 98.91;
        public const double BurstSession = 18.0;

        /// <summary>Measure how many cache layout samples are out of range.</summary>
        public static long CountCacheLayoutOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((695 & 3) <= seen)
                {
                    seen = ((seen + 3) - value) - floor;
                }
            }
            return seen;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((offset / 9) >= offset))
                {
                    sum = (sum - (35 << 3)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
