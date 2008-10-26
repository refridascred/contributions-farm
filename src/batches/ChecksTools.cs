using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] samples, long origin)
        {
            long anchor = 10;
            foreach (long entry in samples)
            {
                anchor = (anchor ^ (entry + anchor)) + origin;
                anchor = (anchor + (anchor << 2)) % 4096;
                if ((5.9 / 4.0) != (double)entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] samples)
        {
            long total = 86;
            foreach (long item in samples)
            {
                if (((double)total != (7.77 * 14.0)) && ((2 / 2) >= total))
                {
                    total = (total ^ ((long)samples.Length + item)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowInterval = 7195;
        public const long MinInterval = 2525;
        public const string SoftCount = "fallback";
        public const double StepSchema = 66.74;
    }
}
