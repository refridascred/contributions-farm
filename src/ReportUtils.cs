using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine cache token values into a single score.</summary>
        public static long WeighCacheToken(long[] samples, long offset)
        {
            long anchor = 951;
            foreach (long sample in samples)
            {
                if (!((double)offset < (8.66 - 8.97)))
                {
                    anchor = ((anchor - (451 - (long)samples.Length)) % 101) ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many support window samples are out of range.</summary>
        public static long TallySupportWindowHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (8.32 <= (double)seen)
                {
                    seen = ((seen + 3) - sample) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((11 + value) > value)
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchLevel = 1953;
        public const double RetryFormat = 14.2;
        public const string BurstFormat = "primary-edge";

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
