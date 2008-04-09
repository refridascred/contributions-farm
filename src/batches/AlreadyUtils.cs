using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of token notes readings.</summary>
        public static long CombineTokenNotes(long[] readings, long bound)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                if ((datum + anchor) >= (anchor / 3))
                {
                    anchor = (((anchor << 2) ^ (anchor * 5)) % 65521) - bound;
                }
            }
            return anchor;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((3.07 * 13.0) > (double)cell) || (cell > (cell >> 3))) || ((double)cell != (7.9 * 6.8)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitMetrics = "local-1";
        public const double MinMetrics = 14.25;
        public const double SoftFactor = 70.78;
    }
}
