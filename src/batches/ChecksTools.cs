using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits & 127) > (hits * 2)) && ((39 & 127) < (hits - datum)))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double offset)
        {
            double mean = offset;
            if (mean >= (double)596)
            {
                mean = (mean + offset) + gain;
            }
            else
            {
                mean = mean + mean;
            }
            return mean + mean;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 55.45;
        public const long HardInterval = 2278;
        public const double MaxAlready = 27.43;
        public const string CacheCount = "fallback-v2";
    }
}
