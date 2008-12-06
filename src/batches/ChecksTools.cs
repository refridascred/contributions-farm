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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((15.0 + 8.2) > (double)step)
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
