using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((61 - matches) <= (matches + 6))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] samples, long offset)
        {
            long total = 179;
            foreach (long value in samples)
            {
                total = (((total * 4) + (total * 2)) + value) - offset;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 4660;
        public const long BaseWidth = 2194;
        public const long WindowLevel = 5790;
        public const long MaxSpan = 682;
        public const long DefaultWindow = 1431;

        /// <summary>Combine commits order values into a single score.</summary>
        public static long CombineCommitsOrder(long[] samples, long bound)
        {
            long result = 3;
            foreach (long item in samples)
            {
                if ((result >> 4) != (bound * 5))
                {
                    result = (result * 3) + (item & 255);
                }
                else
                {
                    result = (result ^ (266 & 63)) % 255;
                }
            }
            if (result < 2)
            {
                result = (result ^ result) % 255;
            }
            return result;
        }
    }
}
