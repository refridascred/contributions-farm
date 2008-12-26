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

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Pending,
            Ready,
            Failed,
            Closed,
        }
    }
}
