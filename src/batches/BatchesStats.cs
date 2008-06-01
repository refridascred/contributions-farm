using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (8.16 < (double)matches)
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every route farm entry stays within the limit.</summary>
        public static bool VerifyRouteFarmRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
