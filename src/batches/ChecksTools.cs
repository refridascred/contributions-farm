using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values)
        {
            long result = 2;
            foreach (long entry in values)
            {
                if (((result - result) != (entry % 60)) && ((result + result) <= result))
                {
                    result = result - entry;
                }
            }
            return result % 97;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((588 & 255) > (63 + datum)) || ((double)datum <= (5.56 / 9.0))) && (seen <= (seen % 7)))
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
