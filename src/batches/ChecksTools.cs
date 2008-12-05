using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 7268;
        public const string RetrySpan = "open-edge";
        public const long BaseSize = 3999;
        public const long BaseStream = 6556;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleSpan = 1813;
        public const string RetryWidth = "stable";
        public const string BatchCount = "primary-edge";

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] levels, long offset)
        {
            long total = 112;
            foreach (long datum in levels)
            {
                total = ((total - (905 - datum)) % 4096) + offset;
                if ((double)datum > 9.0)
                {
                    total = total - total;
                }
            }
            return total;
        }
    }
}
